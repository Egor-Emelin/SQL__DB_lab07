
namespace SQL__DB_lab07
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_exit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_remove_build = new System.Windows.Forms.Button();
            this.button_update_build = new System.Windows.Forms.Button();
            this.button_add_build = new System.Windows.Forms.Button();
            this.button_load_build = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_remove = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_load = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_remove_priv = new System.Windows.Forms.Button();
            this.button_update_priv = new System.Windows.Forms.Button();
            this.button_add_priv = new System.Windows.Forms.Button();
            this.button_load_priv = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button_request3 = new System.Windows.Forms.Button();
            this.button_request2 = new System.Windows.Forms.Button();
            this.button_request1 = new System.Windows.Forms.Button();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage7.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            this.SuspendLayout();
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(12, 12);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(86, 38);
            this.button_exit.TabIndex = 0;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(12, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1351, 540);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1343, 500);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Buildings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1023, 571);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_remove_build);
            this.groupBox2.Controls.Add(this.button_update_build);
            this.groupBox2.Controls.Add(this.button_add_build);
            this.groupBox2.Controls.Add(this.button_load_build);
            this.groupBox2.Location = new System.Drawing.Point(1029, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 604);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose";
            // 
            // button_remove_build
            // 
            this.button_remove_build.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_remove_build.Location = new System.Drawing.Point(7, 365);
            this.button_remove_build.Name = "button_remove_build";
            this.button_remove_build.Size = new System.Drawing.Size(305, 107);
            this.button_remove_build.TabIndex = 3;
            this.button_remove_build.Text = "Remove";
            this.button_remove_build.UseVisualStyleBackColor = true;
            this.button_remove_build.Click += new System.EventHandler(this.button_remove_build_Click);
            // 
            // button_update_build
            // 
            this.button_update_build.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_update_build.Location = new System.Drawing.Point(7, 252);
            this.button_update_build.Name = "button_update_build";
            this.button_update_build.Size = new System.Drawing.Size(305, 107);
            this.button_update_build.TabIndex = 2;
            this.button_update_build.Text = "Update";
            this.button_update_build.UseVisualStyleBackColor = true;
            this.button_update_build.Click += new System.EventHandler(this.button_update_build_Click);
            // 
            // button_add_build
            // 
            this.button_add_build.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add_build.Location = new System.Drawing.Point(7, 139);
            this.button_add_build.Name = "button_add_build";
            this.button_add_build.Size = new System.Drawing.Size(305, 107);
            this.button_add_build.TabIndex = 1;
            this.button_add_build.Text = "Add";
            this.button_add_build.UseVisualStyleBackColor = true;
            this.button_add_build.Click += new System.EventHandler(this.button_add_build_Click);
            // 
            // button_load_build
            // 
            this.button_load_build.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_load_build.Location = new System.Drawing.Point(7, 26);
            this.button_load_build.Name = "button_load_build";
            this.button_load_build.Size = new System.Drawing.Size(305, 107);
            this.button_load_build.TabIndex = 0;
            this.button_load_build.Text = "Load";
            this.button_load_build.UseVisualStyleBackColor = true;
            this.button_load_build.Click += new System.EventHandler(this.button_load_build_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1343, 500);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Apartments";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1023, 604);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_remove);
            this.groupBox1.Controls.Add(this.button_update);
            this.groupBox1.Controls.Add(this.button_add);
            this.groupBox1.Controls.Add(this.button_load);
            this.groupBox1.Location = new System.Drawing.Point(1029, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 604);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose";
            // 
            // button_remove
            // 
            this.button_remove.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_remove.Location = new System.Drawing.Point(7, 365);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(305, 107);
            this.button_remove.TabIndex = 3;
            this.button_remove.Text = "Remove";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // button_update
            // 
            this.button_update.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_update.Location = new System.Drawing.Point(7, 252);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(305, 107);
            this.button_update.TabIndex = 2;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.Location = new System.Drawing.Point(7, 139);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(305, 107);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click_1);
            // 
            // button_load
            // 
            this.button_load.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_load.Location = new System.Drawing.Point(7, 26);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(305, 107);
            this.button_load.TabIndex = 0;
            this.button_load.Text = "Load";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 36);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1343, 500);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Privatization";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_remove_priv);
            this.groupBox3.Controls.Add(this.button_update_priv);
            this.groupBox3.Controls.Add(this.button_add_priv);
            this.groupBox3.Controls.Add(this.button_load_priv);
            this.groupBox3.Location = new System.Drawing.Point(1029, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(318, 604);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Choose";
            // 
            // button_remove_priv
            // 
            this.button_remove_priv.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_remove_priv.Location = new System.Drawing.Point(7, 365);
            this.button_remove_priv.Name = "button_remove_priv";
            this.button_remove_priv.Size = new System.Drawing.Size(305, 107);
            this.button_remove_priv.TabIndex = 3;
            this.button_remove_priv.Text = "Remove";
            this.button_remove_priv.UseVisualStyleBackColor = true;
            this.button_remove_priv.Click += new System.EventHandler(this.button_remove_priv_Click);
            // 
            // button_update_priv
            // 
            this.button_update_priv.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_update_priv.Location = new System.Drawing.Point(7, 252);
            this.button_update_priv.Name = "button_update_priv";
            this.button_update_priv.Size = new System.Drawing.Size(305, 107);
            this.button_update_priv.TabIndex = 2;
            this.button_update_priv.Text = "Update";
            this.button_update_priv.UseVisualStyleBackColor = true;
            this.button_update_priv.Click += new System.EventHandler(this.button_update_priv_Click);
            // 
            // button_add_priv
            // 
            this.button_add_priv.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add_priv.Location = new System.Drawing.Point(7, 139);
            this.button_add_priv.Name = "button_add_priv";
            this.button_add_priv.Size = new System.Drawing.Size(305, 107);
            this.button_add_priv.TabIndex = 1;
            this.button_add_priv.Text = "Add";
            this.button_add_priv.UseVisualStyleBackColor = true;
            this.button_add_priv.Click += new System.EventHandler(this.button_add_priv_Click);
            // 
            // button_load_priv
            // 
            this.button_load_priv.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_load_priv.Location = new System.Drawing.Point(7, 26);
            this.button_load_priv.Name = "button_load_priv";
            this.button_load_priv.Size = new System.Drawing.Size(305, 107);
            this.button_load_priv.TabIndex = 0;
            this.button_load_priv.Text = "Load";
            this.button_load_priv.UseVisualStyleBackColor = true;
            this.button_load_priv.Click += new System.EventHandler(this.button_load_priv_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(0, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(1023, 571);
            this.dataGridView3.TabIndex = 4;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.groupBox7);
            this.tabPage7.Controls.Add(this.dataGridView7);
            this.tabPage7.Location = new System.Drawing.Point(4, 36);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1343, 500);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Requests";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button_request3);
            this.groupBox7.Controls.Add(this.button_request2);
            this.groupBox7.Controls.Add(this.button_request1);
            this.groupBox7.Location = new System.Drawing.Point(1029, 0);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(318, 604);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Choose";
            // 
            // button_request3
            // 
            this.button_request3.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_request3.Location = new System.Drawing.Point(7, 252);
            this.button_request3.Name = "button_request3";
            this.button_request3.Size = new System.Drawing.Size(305, 107);
            this.button_request3.TabIndex = 2;
            this.button_request3.Text = "Request3";
            this.button_request3.UseVisualStyleBackColor = true;
            this.button_request3.Click += new System.EventHandler(this.button_request3_Click);
            // 
            // button_request2
            // 
            this.button_request2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_request2.Location = new System.Drawing.Point(7, 139);
            this.button_request2.Name = "button_request2";
            this.button_request2.Size = new System.Drawing.Size(305, 107);
            this.button_request2.TabIndex = 1;
            this.button_request2.Text = "Request2";
            this.button_request2.UseVisualStyleBackColor = true;
            this.button_request2.Click += new System.EventHandler(this.button_request2_Click);
            // 
            // button_request1
            // 
            this.button_request1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_request1.Location = new System.Drawing.Point(7, 26);
            this.button_request1.Name = "button_request1";
            this.button_request1.Size = new System.Drawing.Size(305, 107);
            this.button_request1.TabIndex = 0;
            this.button_request1.Text = "Request1";
            this.button_request1.UseVisualStyleBackColor = true;
            this.button_request1.Click += new System.EventHandler(this.button_request1_Click);
            // 
            // dataGridView7
            // 
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Location = new System.Drawing.Point(0, 0);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.RowHeadersWidth = 62;
            this.dataGridView7.RowTemplate.Height = 28;
            this.dataGridView7.Size = new System.Drawing.Size(1023, 604);
            this.dataGridView7.TabIndex = 2;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1361, 627);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button_exit);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_remove_build;
        private System.Windows.Forms.Button button_update_build;
        private System.Windows.Forms.Button button_add_build;
        private System.Windows.Forms.Button button_load_build;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_remove_priv;
        private System.Windows.Forms.Button button_update_priv;
        private System.Windows.Forms.Button button_add_priv;
        private System.Windows.Forms.Button button_load_priv;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button_request3;
        private System.Windows.Forms.Button button_request2;
        private System.Windows.Forms.Button button_request1;
        private System.Windows.Forms.DataGridView dataGridView7;
    }
}

