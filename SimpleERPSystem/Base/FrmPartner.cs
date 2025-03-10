using ComponentFactory.Krypton.Toolkit;
using ERP_BLL;
using ERP_CL;
using ERP_MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace SimpleERPSystem.Base
{
    public partial class FrmPartner : DockContent
    {

        #region 辅助字段、结构体、函数

        #region 辅助字段: bll / model / tempQueryModel
        /// <summary>
        /// 实例化子代码业务处理层，用于业务操作
        /// </summary>
        B_partner_BLL bll = new B_partner_BLL();

        /// <summary>
        /// 实例化子代码对象，用于数据封装。
        /// 实际需要自行实例化，避免读取错误。
        /// </summary>
        B_partner model;

        /// <summary>
        /// 用于缓存查找结果
        /// </summary>
        B_partner tempQueryResultModel = null;

        #endregion

        #region 辅助结构体 DefaultComboBoxValue
        /// <summary>
        /// 辅助结构，用于存储窗体加载时从数据库获取的默认值。
        /// <para>
        ///     只在窗体加载事件中赋值，在 <c>IsPanelClear()</c> 中用于检验是否与默认值一致。
        ///     包含两个字段 <c>pay_type</c> / <c>bank_cd</c>，均为静态字符串类型。
        /// </para>
        /// </summary>
        private struct DefaultComboBoxValue
        {
            public static string pay_type;
            public static string bank_cd;
        }
        #endregion

        #region 辅助函数: IsPanelClear() / Query() / Clear_pnl_partner_info()
        /// <summary>
        /// 确认面板是否为空。在 添加按钮触发 / 删除按钮触发 时被调用.
        /// <para>
        ///     对于添加按钮：用于确认是面板启用的 新增 / 修改选取值 的哪一项，
        ///         如果返回 <c>false</c> 说明 有新增值 / 选取过值，其中
        ///         通过对 <c>txt_bp_cd</c> 的锁定保证如果选取了值则一定会返回 <c>false</c>。
        /// </para>
        /// <para>
        ///     对于删除按钮：用于确定删除前是否有有效数据，
        ///         如果返回 <c>true</c>，说明是 点击新增但未输入值 / 未选取值，
        ///         只需要直接锁定面板即可。
        /// </para>
        /// </summary>
        /// <returns>
        ///     <c>True</c> 则说明 <c>pnl_partner_info</c> 中内容均为默认值，
        ///     <c>False</c> 说明存在至少一处改动。
        /// </returns>
        private bool IsPanelClear()
        {
            /* 用于测试输出
            MessageBox.Show((txt_bp_cd.Text.Trim() == String.Empty).ToString() + "\n" +
            (txt_bp_full_nm.Text.Trim() == String.Empty).ToString() + "\n" +
            (txt_bp_nm.Text.Trim() == String.Empty).ToString() + "\n" +
            (txt_bp_addr.Text.Trim() == String.Empty).ToString() + "\n" +
            (txt_bp_repre.Text.Trim() == String.Empty).ToString() + "\n" +
            (txt_bp_email.Text.Trim() == String.Empty).ToString() + "\n" +
            (txt_bp_tel.Text.Trim() == String.Empty).ToString() + "\n" +
            (txt_bp_tax.Text.Trim() == String.Empty).ToString() + "\n" +
            (txt_bank_acct_no.Text.Trim() == String.Empty).ToString() + "\n" +
            (txt_remark.Text.Trim() == String.Empty).ToString() + "\n" +
            (cb_so_flag.Checked == false).ToString() + "\n" +
            (cb_po_flag.Checked == false).ToString() + "\n" +
            (cbb_bank_cd.Text == default_bank_cd).ToString() + "\n" +
           (cbb_pay_type.Text == default_pay_type).ToString());
             */
            return
            txt_bp_cd.Text.Trim() == String.Empty &&
            txt_bp_full_nm.Text.Trim() == String.Empty &&
            txt_bp_nm.Text.Trim() == String.Empty &&
            txt_bp_addr.Text.Trim() == String.Empty &&
            txt_bp_repre.Text.Trim() == String.Empty &&
            txt_bp_email.Text.Trim() == String.Empty &&
            txt_bp_tel.Text.Trim() == String.Empty &&
            txt_bp_tax.Text.Trim() == String.Empty &&
            txt_bank_acct_no.Text.Trim() == String.Empty &&
            txt_remark.Text.Trim() == String.Empty &&
            cb_so_flag.Checked == false &&
            cb_po_flag.Checked == false &&
            cbb_bank_cd.Text == DefaultComboBoxValue.bank_cd &&
            cbb_pay_type.Text == DefaultComboBoxValue.pay_type;
        }

        /// <summary>
        /// 作为清除 <c>pnl_partner_info</c> 中内容的辅助函数，
        /// 在 添加按钮触发 / 删除按钮触发 / 保存按钮触发时被调用。
        /// <para>
        ///     对于添加按钮，确认新增操作后需要清除面板内容。
        /// </para>
        /// <para>
        ///     对于删除按钮，确认面板非空后清除面板内容：
        ///         如果是新增后删除，直接清除内容；
        ///         如果是查询选取后删除，先清除内容后操作数据库。
        /// </para>
        /// <para>
        /// 
        /// </para>
        /// </summary>
        private void Clear_pnl_partner_info()
        {
            // 重置 CheckBox 内容
            this.cb_so_flag.Checked = false;
            this.cb_po_flag.Checked = false;
            // 重置特殊的 txt_bp_cd
            txt_bp_cd.Text = "";
            //使用字段 txt、cbb 作为中继变量
            ERP_TextBox txt;
            KryptonComboBox cbb;
            /*  使用foreach循环遍历控件，对每一个ERP_TextBox控件进行清空操作
             *  其中 pnl_partner_info 为存放 ERP_TextBox 控件的Panel控件
             *  它的 Controls属性存放了所有子控件，均基于 Control 父类    */
            /* 可以用类似于下面的代码进行重写，其中只写了 ERO_TextBox 类型的控件清空操作
            for (int i = 0; i < pnl_partner_info.Controls.Count; i++)
            {
                if ("ERP_CL."+pnl_partner_info.Controls[i].GetType().Name 
                                            == typeof(ERP_TextBox).ToString())
                {
                    txt = (ERP_TextBox)pnl_partner_info.Controls[i];
                    txt.Text = string.Empty;
                }
            }
             */
            foreach (Control item in pnl_partner_info.Controls)
            {
                string name = item.GetType().Name;
                /*  用于测试时比对类型
                 MessageBox.Show("ComponentFactory.Krypton.Toolkit." + name
                    + '\n' + typeof(ERP_CL.ERP_TextBox).ToString()
                    + '\n' + typeof(ComponentFactory.Krypton.Toolkit.KryptonCheckBox).ToString());
                 */
                /* 对 item 进行类型判断，如果是 ERP_TextBox 类型，则进行清空操作
                 * 但是通过 GetType().Name 获取的是类的全名，不含命名空间，
                 * 需要加上命名空间然后进行比较   */
                if (("ERP_CL." + name) == typeof(ERP_TextBox).ToString())
                {
                    txt = (ERP_TextBox)item;
                    txt.Text = string.Empty;
                }
                /* // 直接设置选取索引为0
                 else if ("ComponentFactory.Krypton.Toolkit." + name
                    == typeof(KryptonComboBox).ToString())
                {
                    cbb = (KryptonComboBox)item;
                    cbb.Text = string.Empty;
                }
                 */
                cbb_pay_type.SelectedIndex = 0;
                cbb_bank_cd.SelectedIndex = 0;
            }
            this.txt_bp_cd.Focus();
        }

        /// <summary>
        ///     查询函数，为方便调用而设置
        /// </summary>
        /// <exception cref="1002: 查找失败！未找到所要操作数据，请确认查找条件是否正确！"/>
        private void Query()
        {
            model = new B_partner();
            // 数据封装
            if (rbtn_query_so.Checked == true)
                model.so_flag = true;
            else if (rbtn_query_po.Checked == true)
                model.po_flag = true;
            else if (rbtn_query_all.Checked == true)
                model.so_flag = model.po_flag = true;
            model.bp_full_nm = txt_query_bp_full_nm.Text.Trim();
            model.bp_repre = txt_query_bp_repre.Text.Trim();

            //MessageBox.Show(model.flag.ToString());
            // 数据绑定
            DataTable dt = bll.Get_B_Partner(model);
            dgView.DataSource = dt;

            // 先绑定数据源，再判断是否有数据
            if (dt.Rows.Count == 0)
            {
                B_Message_BLL.ShowConfirm("1002");
            }
        }

        #endregion

        #region 缓存函数、验证更改函数 GetPanelShowModel()、DataChange()

        /// <summary>
        /// 获取 pnl_partner_info 中的内容。
        /// 在 选取查询返回值 / 保存数据 时被调用。
        /// </summary>
        /// <returns>
        /// 获取内容所构造的新 B_partner 实例。
        /// </returns>
        private B_partner GetPanelShowModel()
        {
            B_partner newB_parter = new B_partner();
            newB_parter.bp_cd = txt_bp_cd.Text.Trim();
            newB_parter.bp_full_nm = txt_bp_full_nm.Text.Trim();
            newB_parter.bp_nm = txt_bp_nm.Text.Trim();
            newB_parter.bp_addr = txt_bp_addr.Text.Trim();
            newB_parter.bp_repre = txt_bp_repre.Text.Trim();
            newB_parter.bp_email = txt_bp_email.Text.Trim();
            newB_parter.bp_tel = txt_bp_tel.Text.Trim();
            newB_parter.bp_tax = txt_bp_tax.Text.Trim();
            newB_parter.bank_acct_no = txt_bank_acct_no.Text.Trim();
            newB_parter.remark = txt_remark.Text.Trim();
            newB_parter.so_flag = cb_so_flag.Checked;
            newB_parter.po_flag = cb_po_flag.Checked;
            newB_parter.bank_cd = cbb_bank_cd.SelectedValue.ToString();
            newB_parter.pay_type = cbb_pay_type.SelectedValue.ToString();
            newB_parter.user_cd = FrmMain.user_id;
            return newB_parter;
        }

        /// <summary>
        /// 验证数据是否更改，避免未保存操作丢失，
        /// 在 窗体关闭 / 查询数据 / 新增数据 时调用。
        /// </summary>
        /// <returns>
        ///     <c>True</c> 对应数据已经被更改，
        ///     <c>False</c> 对应数据未被更改或未曾获取过数据。
        /// </returns>
        private bool DataChange()
        {
            // 如果绑定空值，则说明未进行过查询、或者查询后值被新建操作清除
            if (tempQueryResultModel == null)
                return false;
            // 使用 或|| 来保证只要有一组 != 成立就返回 true
            bool result = (
            tempQueryResultModel.bp_cd != txt_bp_cd.Text.Trim() ||
            tempQueryResultModel.bp_full_nm != txt_bp_full_nm.Text.Trim() ||
            tempQueryResultModel.bp_nm != txt_bp_nm.Text.Trim() ||
            tempQueryResultModel.bp_addr != txt_bp_addr.Text.Trim() ||
            tempQueryResultModel.bp_repre != txt_bp_repre.Text.Trim() ||
            tempQueryResultModel.bp_email != txt_bp_email.Text.Trim() ||
            tempQueryResultModel.bp_tel != txt_bp_tel.Text.Trim() ||
            tempQueryResultModel.bp_tax != txt_bp_tax.Text.Trim() ||
            tempQueryResultModel.bank_acct_no != txt_bank_acct_no.Text.Trim() ||
            tempQueryResultModel.remark != txt_remark.Text.Trim() ||
            tempQueryResultModel.so_flag != cb_so_flag.Checked ||
            tempQueryResultModel.po_flag != cb_po_flag.Checked ||
            tempQueryResultModel.bank_cd != cbb_bank_cd.SelectedValue.ToString() ||
            tempQueryResultModel.pay_type != cbb_pay_type.SelectedValue.ToString());
            /* 
            // 用于测试
                MessageBox.Show((tempQueryResultModel.remark).ToString()+"\n txt:"+ (txt_remark.Text.Trim()).ToString());
                MessageBox.Show((tempQueryResultModel.bank_cd != cbb_bank_cd.SelectedValue.ToString()).ToString()
                    +"\n"+(tempQueryResultModel.pay_type != cbb_pay_type.SelectedValue.ToString()).ToString());
            // 用于测试
            MessageBox.Show(result.ToString());
             */
            return result;
        }
        #endregion

        #endregion

        #region 窗体构造函数、加载事件
        /// <summary>
        /// 构造函数
        /// </summary>
        public FrmPartner()
        {
            InitializeComponent();
        }


        /// <summary>
        ///     窗体加载事件
        /// <para>
        ///     窗体加载时，从数据库中获取主代码为 <c>1002</c> 的子代码名称表，
        ///     并加载在 <c>cbb_bank_cd</c> 上；
        ///     同理加载 <c>1001</c> 到 <c>cbb_pay_type</c> 上。
        /// </para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPartner_Load(object sender, EventArgs e)
        {
            // 定义辅助变量
            B_minor b_Minor = new B_minor();
            B_minor_BLL b_Minor_BLL = new B_minor_BLL();
            // 绑定 cbb_bank_cd 的值
            b_Minor.major_cd = "1002";
            DataTable dt_bank_cd = b_Minor_BLL.Get_Minor_nm(b_Minor);
            cbb_bank_cd.DataSource = dt_bank_cd;
            cbb_bank_cd.DisplayMember = "minor_nm";
            cbb_bank_cd.ValueMember = "minor_cd";
            // 绑定 cbb_pay_type 的值
            b_Minor.major_cd = "1001";
            DataTable dt_pay_type = b_Minor_BLL.Get_Minor_nm(b_Minor);
            cbb_pay_type.DataSource = dt_pay_type;
            cbb_pay_type.DisplayMember = "minor_nm";
            cbb_pay_type.ValueMember = "minor_cd";
            // 设置辅助字段值
            DefaultComboBoxValue.bank_cd = cbb_bank_cd.Text;
            DefaultComboBoxValue.pay_type = cbb_pay_type.Text;
            // 窗体构造时禁用 pnl_partner_info
            pnl_partner_info.Enabled = false;
        }

        /// <summary>
        /// 窗体关闭事件，询问未保存数据。
        /// <para>
        ///     在 <c>UserClosing</c> / <c>MdiFormClosing</c> 时触发。
        /// </para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="2101: 存在未保存数据，确认以继续操作"/>
        private void FrmPartner_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing 
                || e.CloseReason == CloseReason.MdiFormClosing)
            {  // 存在未保存数据，提示用户是否继续关闭
                if (pnl_partner_info.Enabled == true && DataChange() == true)
                {   // 用户选择 No 时，取消关闭窗体
                    if (B_Message_BLL.ShowYesOrNo("2101") == DialogResult.No)
                    {
                        e.Cancel = true;  // 取消 FormClosing 事件，默认为 false
                        return;
                    }
                    else  // 用户选择 Yes 时，确认关闭窗体(默认发生)
                    {
                        e.Cancel = false;  // 确认关闭窗体
                        return;
                    }
                }
            }
        }
        #endregion

        #region 按钮事件

        #region 查找按钮事件、数据显示事件 btnSearch_Click / dgView_CellClick
        /// <summary>
        /// 查询按钮事件
        /// <para>
        ///     通过检查 <c>pnl_partner_info</c> 是否启用
        ///     和 <c>DataChange()</c> 的值来判断是否有未保存数据。
        ///     若无未保存数据则校验查找条件，最后查询并启用 <c>pnl_partner_info</c>
        /// </para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="2102: 当前有未保存的数据，是否继续操作？"
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // 如果面板启用: 有新增或有选取
            // 且数据被修改: 获取过数据并修改
            if(pnl_partner_info.Enabled && DataChange())
            {
                if (B_Message_BLL.ShowYesOrNo("2101") == DialogResult.No)
                    return;
            }
            Query();
            /* // 不需要查找后设置可用，因而注释掉
            if (dgView.Rows.Count != 0)
                pnl_partner_info.Enabled = true;
            else
                return;
             */
        }

        /// <summary>
        /// 点击 <c>dgView</c> 中数据时显示查询结果。
        /// <para>
        ///     点击后会将 <c>txt_bp_cd</c> 禁用，防止对主键的编辑破坏。
        /// </para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 如果选中表头则直接返回
            if (e.ColumnIndex < -1 || e.RowIndex < 0) 
                return;
            // 将 txt_bp_cd 禁用防止对主键破坏
            txt_bp_cd.Enabled = false;
            // 可以给控件加 tag 然后遍历容器赋值
            // 这里选用直接赋值简化代码逻辑
            txt_bp_cd.Text          = dgView[bp_cd.Name, e.RowIndex].Value.ToString();
            txt_bp_full_nm.Text     = dgView[bp_full_nm.Name, e.RowIndex].Value.ToString();
            txt_bp_nm.Text          = dgView[bp_nm.Name,e.RowIndex].Value.ToString();
            txt_bp_addr.Text        = dgView[bp_addr.Name, e.RowIndex].Value.ToString();
            txt_bp_repre.Text       = dgView[bp_repre.Name, e.RowIndex].Value.ToString();
            txt_bp_email.Text       = dgView[bp_email.Name, e.RowIndex].Value.ToString();
            txt_bp_tel.Text         = dgView[bp_tel.Name, e.RowIndex].Value.ToString();
            txt_bp_tax.Text         = dgView[bp_tax.Name, e.RowIndex].Value.ToString();
            txt_bank_acct_no.Text   = dgView[bank_acct_no.Name, e.RowIndex].Value.ToString();
            txt_remark.Text         = dgView[remark.Name, e.RowIndex].Value.ToString();
            // CheckBox 赋值，赋值基于判断获取的 DataTable 其中字段是否为 "Y"
            cb_so_flag.Checked = dgView[so_flag.Name,e.RowIndex].Value.ToString() == "Y";
            cb_po_flag.Checked = dgView[po_flag.Name, e.RowIndex].Value.ToString() == "Y";
            // ComboBox 赋值
            cbb_bank_cd.SelectedValue = dgView[bank_cd.Name, e.RowIndex].Value;
            cbb_pay_type.SelectedValue = dgView[pay_type.Name, e.RowIndex].Value;
            // 保证编辑可达
            pnl_partner_info.Enabled = true;
            tempQueryResultModel = GetPanelShowModel();
        }
        #endregion

        #region 增删存按钮事件 btnAdd_Click / btnDel_Click / btnSave_Click
        /// <summary>
        /// 添加按钮，点击后清除显示数据，并将 <c>txt_bp_cd</c> 启用。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 如果没有绑定数据源，则先查询(此时绑定数据源)
            if (dgView.DataSource == null)
                Query();
            // 如果面板启用、且面板非空、且数据被修改
            // 则证明是经查询并被修改，询问是否继续当前新增操作
            ///面板未启用 -> 不存在数据操作与选取；
            ///面板启用、面板为空 -> 已经点击过一次添加按钮
            ///面板启用、且面板非空、数据未被修改 -> 显示之前查询并选取的结果
            if (pnl_partner_info.Enabled == true 
                && IsPanelClear() == false
                && DataChange() == true
                && B_Message_BLL.ShowYesOrNo("2101") == DialogResult.No)
                return;
            // 确认新增操作则清除之前查询并显示的面板
            Clear_pnl_partner_info();
            tempQueryResultModel = null;
            // 保证可编辑
            pnl_partner_info.Enabled = true;
            txt_bp_cd.Enabled = true;
        }

        /// <summary>
        /// 删除按钮，点击提示是否删除，确认后删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="2102: 敏感操作：删除，确认以继续操作"/>
        private void btnDel_Click(object sender, EventArgs e)
        {
            // 如果为空面板，直接禁用面板
            if (IsPanelClear() == true)
            {
                pnl_partner_info.Enabled = false;
                txt_bp_cd.Enabled = false;
                return;
            }
            // 如果面板非空且启用 txt_bp_cd 则需要清空后禁用
            if (txt_bp_cd.Enabled == true)
            {
                Clear_pnl_partner_info();
                pnl_partner_info.Enabled = false;
                txt_bp_cd.Enabled = false;
                return;
            }
            /* // 错误的判断逻辑
             // 如果 pnl_partner_info 启用，则说明存在编辑中数据
            // 此时调用 DataChange() 判断是否存在数据改动
            // 如果存在则弹窗，选择 No 则停止操作
            if (pnl_partner_info.Enabled == true
                && IsPanelClear() == false
                && DataChange() == true
                && B_Message_BLL.ShowYesOrNo("2101") == DialogResult.No)
                return;
             */
            // 面板非空，未启用 txt_bp_cd 则需要操作数据库清除并刷新
            if (B_Message_BLL.ShowYesOrNo("2102") == DialogResult.Yes)
            {
                model = new B_partner();
                model.bp_cd = txt_bp_cd.Text.Trim();
                bll.Delete_B_Partner(model);
                Clear_pnl_partner_info();
                pnl_partner_info.Enabled = false;
                Query();
                B_Message_BLL.ShowConfirm("0001");
            }
        }

        /// <summary>
        /// 保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            // 缓存当前值
            model = GetPanelShowModel();
            // 新增操作判断，如果 bp_cd 可编辑则新增
            if (txt_bp_cd.Enabled == true)
            {   // 如果插入成功则关闭
                if (bll.Insert_B_Partner(model) == true)
                {
                    txt_bp_cd.Enabled = false;
                }
                else // 插入失败不清理面板，但是查询并返回
                {
                    Query();
                    return;
                }
            }
            // 不可编辑则更新
            else
            {   // 更新失败不清理面板，但是查询并返回
                if (bll.Update_B_Partner(model)==false)
                {
                    Query();
                    return;
                }
            }
            pnl_partner_info.Enabled = false;
            B_Message_BLL.ShowConfirm("0001");
            Clear_pnl_partner_info();
            Query();
        }
        #endregion

        #endregion

    }
}
