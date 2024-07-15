namespace Guest_Shabbat_Host_App.Views
{
    partial class HostForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "foo" }, -1, Color.Empty, Color.FromArgb(192, 255, 192), null);
            ListViewItem listViewItem2 = new ListViewItem("bar");
            label_cateogry = new ReaLTaiizor.Controls.MaterialLabel();
            textbox_category = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            label_addCategory = new Label();
            label_categoryList = new ReaLTaiizor.Controls.MaterialLabel();
            listView_categoryList = new ReaLTaiizor.Controls.MaterialListView();
            categories = new ColumnHeader();
            SuspendLayout();
            // 
            // label_cateogry
            // 
            label_cateogry.AutoSize = true;
            label_cateogry.Depth = 0;
            label_cateogry.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            label_cateogry.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            label_cateogry.Location = new Point(42, 105);
            label_cateogry.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            label_cateogry.Name = "label_cateogry";
            label_cateogry.Size = new Size(208, 24);
            label_cateogry.TabIndex = 0;
            label_cateogry.Text = "מערכת אירוח - הכנסת קטגוריות";
            // 
            // textbox_category
            // 
            textbox_category.AnimateReadOnly = false;
            textbox_category.AutoCompleteMode = AutoCompleteMode.None;
            textbox_category.AutoCompleteSource = AutoCompleteSource.None;
            textbox_category.BackgroundImageLayout = ImageLayout.None;
            textbox_category.CharacterCasing = CharacterCasing.Normal;
            textbox_category.Depth = 0;
            textbox_category.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textbox_category.HideSelection = true;
            textbox_category.LeadingIcon = null;
            textbox_category.Location = new Point(42, 143);
            textbox_category.MaxLength = 32767;
            textbox_category.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            textbox_category.Name = "textbox_category";
            textbox_category.PasswordChar = '\0';
            textbox_category.PrefixSuffixText = null;
            textbox_category.ReadOnly = false;
            textbox_category.RightToLeft = RightToLeft.No;
            textbox_category.SelectedText = "";
            textbox_category.SelectionLength = 0;
            textbox_category.SelectionStart = 0;
            textbox_category.ShortcutsEnabled = true;
            textbox_category.Size = new Size(250, 48);
            textbox_category.TabIndex = 1;
            textbox_category.TabStop = false;
            textbox_category.TextAlign = HorizontalAlignment.Right;
            textbox_category.TrailingIcon = null;
            textbox_category.UseSystemPasswordChar = false;
            // 
            // label_changePassword
            // 
            label_addCategory.AutoSize = true;
            label_addCategory.BackColor = Color.FromArgb(61, 81, 181);
            label_addCategory.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_addCategory.ForeColor = SystemColors.ButtonHighlight;
            label_addCategory.Location = new Point(42, 226);
            label_addCategory.MinimumSize = new Size(251, 48);
            label_addCategory.Name = "label_changePassword";
            label_addCategory.Size = new Size(251, 48);
            label_addCategory.TabIndex = 5;
            label_addCategory.Text = "הוספה";
            label_addCategory.TextAlign = ContentAlignment.MiddleCenter;
            label_addCategory.Click += label_addCategory_Click;
            // 
            // label_categoryList
            // 
            label_categoryList.AutoSize = true;
            label_categoryList.Depth = 0;
            label_categoryList.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            label_categoryList.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            label_categoryList.Location = new Point(43, 351);
            label_categoryList.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            label_categoryList.Name = "label_categoryList";
            label_categoryList.Size = new Size(155, 24);
            label_categoryList.TabIndex = 7;
            label_categoryList.Text = "רשימת קטגוריות קיימות";
            // 
            // listView_categoryList
            // 
            listView_categoryList.AutoSizeTable = false;
            listView_categoryList.BackColor = Color.FromArgb(255, 255, 255);
            listView_categoryList.BorderStyle = BorderStyle.None;
            listView_categoryList.Columns.AddRange(new ColumnHeader[] { categories });
            listView_categoryList.Depth = 0;
            listView_categoryList.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView_categoryList.FullRowSelect = true;
            listView_categoryList.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            listView_categoryList.Location = new Point(43, 389);
            listView_categoryList.MinimumSize = new Size(200, 100);
            listView_categoryList.MouseLocation = new Point(-1, -1);
            listView_categoryList.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            listView_categoryList.Name = "listView_categoryList";
            listView_categoryList.OwnerDraw = true;
            listView_categoryList.RightToLeftLayout = true;
            listView_categoryList.Size = new Size(250, 208);
            listView_categoryList.TabIndex = 6;
            listView_categoryList.UseCompatibleStateImageBehavior = false;
            listView_categoryList.View = View.Details;
            // 
            // categories
            // 
            categories.Text = "קטגוריות";
            categories.Width = 250;
            // 
            // HostForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 664);
            Controls.Add(label_categoryList);
            Controls.Add(listView_categoryList);
            Controls.Add(label_addCategory);
            Controls.Add(textbox_category);
            Controls.Add(label_cateogry);
            Name = "HostForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "מסך מארח";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialLabel label_cateogry;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit textbox_category;
        private Label label_addCategory;
        private ReaLTaiizor.Controls.MaterialLabel label_categoryList;
        private ReaLTaiizor.Controls.MaterialListView listView_categoryList;
        private ColumnHeader categories;
    }
}