namespace OvitaForms
{
    partial class AccountForm
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
            components = new System.ComponentModel.Container();
            accountImagePictureBox = new PictureBox();
            panel1 = new Panel();
            deleteUserButton = new Button();
            updateUserButton = new Button();
            accountEmailLinkLabel = new LinkLabel();
            accoutnPhoneLinkLabel = new LinkLabel();
            accountstaticEmailLabel = new Label();
            accountStaticPhonelabel = new Label();
            accountNameLabel = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            изменитьToolStripMenuItem = new ToolStripMenuItem();
            listView1 = new ListView();
            ((System.ComponentModel.ISupportInitialize)accountImagePictureBox).BeginInit();
            panel1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // accountImagePictureBox
            // 
            accountImagePictureBox.BackColor = Color.FromArgb(255, 192, 192);
            accountImagePictureBox.Location = new Point(12, 12);
            accountImagePictureBox.Name = "accountImagePictureBox";
            accountImagePictureBox.Size = new Size(183, 215);
            accountImagePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            accountImagePictureBox.TabIndex = 0;
            accountImagePictureBox.TabStop = false;
            accountImagePictureBox.Click += accountImagePictureBox_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 224, 192);
            panel1.Controls.Add(deleteUserButton);
            panel1.Controls.Add(updateUserButton);
            panel1.Controls.Add(accountEmailLinkLabel);
            panel1.Controls.Add(accoutnPhoneLinkLabel);
            panel1.Controls.Add(accountstaticEmailLabel);
            panel1.Controls.Add(accountStaticPhonelabel);
            panel1.Controls.Add(accountNameLabel);
            panel1.Location = new Point(201, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(587, 215);
            panel1.TabIndex = 2;
            // 
            // deleteUserButton
            // 
            deleteUserButton.Location = new Point(411, 183);
            deleteUserButton.Name = "deleteUserButton";
            deleteUserButton.Size = new Size(173, 29);
            deleteUserButton.TabIndex = 6;
            deleteUserButton.Text = "Удалить профиль";
            deleteUserButton.UseVisualStyleBackColor = true;
            deleteUserButton.Click += deleteUserButton_Click;
            // 
            // updateUserButton
            // 
            updateUserButton.Location = new Point(184, 183);
            updateUserButton.Name = "updateUserButton";
            updateUserButton.Size = new Size(221, 29);
            updateUserButton.TabIndex = 5;
            updateUserButton.Text = "Редактировать профиль";
            updateUserButton.UseVisualStyleBackColor = true;
            updateUserButton.Click += updateUserButton_Click;
            // 
            // accountEmailLinkLabel
            // 
            accountEmailLinkLabel.AutoSize = true;
            accountEmailLinkLabel.Location = new Point(178, 93);
            accountEmailLinkLabel.Name = "accountEmailLinkLabel";
            accountEmailLinkLabel.Size = new Size(204, 20);
            accountEmailLinkLabel.TabIndex = 4;
            accountEmailLinkLabel.TabStop = true;
            accountEmailLinkLabel.Text = "yagudin.ildar0320@yandex.ru";
            // 
            // accoutnPhoneLinkLabel
            // 
            accoutnPhoneLinkLabel.AutoSize = true;
            accoutnPhoneLinkLabel.Location = new Point(178, 62);
            accoutnPhoneLinkLabel.Name = "accoutnPhoneLinkLabel";
            accoutnPhoneLinkLabel.Size = new Size(107, 20);
            accoutnPhoneLinkLabel.TabIndex = 3;
            accoutnPhoneLinkLabel.TabStop = true;
            accoutnPhoneLinkLabel.Text = "+79172930765";
            // 
            // accountstaticEmailLabel
            // 
            accountstaticEmailLabel.AutoSize = true;
            accountstaticEmailLabel.Location = new Point(12, 93);
            accountstaticEmailLabel.Name = "accountstaticEmailLabel";
            accountstaticEmailLabel.Size = new Size(52, 20);
            accountstaticEmailLabel.TabIndex = 2;
            accountstaticEmailLabel.Text = "E-mail";
            // 
            // accountStaticPhonelabel
            // 
            accountStaticPhonelabel.AutoSize = true;
            accountStaticPhonelabel.Location = new Point(12, 62);
            accountStaticPhonelabel.Name = "accountStaticPhonelabel";
            accountStaticPhonelabel.Size = new Size(127, 20);
            accountStaticPhonelabel.TabIndex = 1;
            accountStaticPhonelabel.Text = "Номер телефона";
            // 
            // accountNameLabel
            // 
            accountNameLabel.AutoSize = true;
            accountNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            accountNameLabel.Location = new Point(12, 10);
            accountNameLabel.Name = "accountNameLabel";
            accountNameLabel.Size = new Size(222, 41);
            accountNameLabel.TabIndex = 0;
            accountNameLabel.Text = "Ягудин Ильдар";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { изменитьToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(70, 26);
            // 
            // изменитьToolStripMenuItem
            // 
            изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            изменитьToolStripMenuItem.Size = new Size(69, 22);
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 233);
            listView1.Name = "listView1";
            listView1.Size = new Size(776, 166);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 402);
            Controls.Add(listView1);
            Controls.Add(panel1);
            Controls.Add(accountImagePictureBox);
            Name = "AccountForm";
            Text = "AccountForm";
            ((System.ComponentModel.ISupportInitialize)accountImagePictureBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox accountImagePictureBox;
        private Panel panel1;
        private LinkLabel accountEmailLinkLabel;
        private LinkLabel accoutnPhoneLinkLabel;
        private Label accountstaticEmailLabel;
        private Label accountStaticPhonelabel;
        private Label accountNameLabel;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem изменитьToolStripMenuItem;
        private ListView listView1;
        private Button deleteUserButton;
        private Button updateUserButton;
    }
}