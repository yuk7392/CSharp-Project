﻿namespace EX11_2
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("베토벤", 1, 1);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("슈베르트", 1, 1);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("모짜르트", 1, 1);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("클래식", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Britney Spears", 1, 1);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Mariah Carey", 1, 1);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Carpenters", 1, 1);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("팝", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("이승환", 1, 1);
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("전인권", 1, 1);
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("이효리", 1, 1);
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("가요", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(19, 18);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "노드2";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Text = "베토벤";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "노드3";
            treeNode2.SelectedImageIndex = 1;
            treeNode2.Text = "슈베르트";
            treeNode3.ImageIndex = 1;
            treeNode3.Name = "노드4";
            treeNode3.SelectedImageIndex = 1;
            treeNode3.Text = "모짜르트";
            treeNode4.Name = "노드1";
            treeNode4.Text = "클래식";
            treeNode5.ImageIndex = 1;
            treeNode5.Name = "노드6";
            treeNode5.SelectedImageIndex = 1;
            treeNode5.Text = "Britney Spears";
            treeNode6.ImageIndex = 1;
            treeNode6.Name = "노드7";
            treeNode6.SelectedImageIndex = 1;
            treeNode6.Text = "Mariah Carey";
            treeNode7.ImageIndex = 1;
            treeNode7.Name = "노드8";
            treeNode7.SelectedImageIndex = 1;
            treeNode7.Text = "Carpenters";
            treeNode8.Name = "노드5";
            treeNode8.Text = "팝";
            treeNode9.ImageIndex = 1;
            treeNode9.Name = "노드10";
            treeNode9.SelectedImageIndex = 1;
            treeNode9.Text = "이승환";
            treeNode10.ImageIndex = 1;
            treeNode10.Name = "노드11";
            treeNode10.SelectedImageIndex = 1;
            treeNode10.Text = "전인권";
            treeNode11.ImageIndex = 1;
            treeNode11.Name = "노드12";
            treeNode11.SelectedImageIndex = 1;
            treeNode11.Text = "이효리";
            treeNode12.Name = "노드9";
            treeNode12.Text = "가요";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8,
            treeNode12});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(321, 326);
            this.treeView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 350);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(320, 21);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "노드추가";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(201, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 24);
            this.button2.TabIndex = 3;
            this.button2.Text = "노드삭제";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-folder-24.png");
            this.imageList1.Images.SetKeyName(1, "icons8-cd-64.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 416);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

