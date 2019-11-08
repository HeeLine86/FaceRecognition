namespace FaceRecognition
{
    partial class MainView
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
            this.I_PB_MAIN = new System.Windows.Forms.PictureBox();
            this.I_GB_CAMERA = new System.Windows.Forms.GroupBox();
            this.I_BTN_START = new System.Windows.Forms.Button();
            this.I_BTN_REFRESH = new System.Windows.Forms.Button();
            this.I_CB_CAMERA = new System.Windows.Forms.ComboBox();
            this.I_GB_FACE = new System.Windows.Forms.GroupBox();
            this.I_BTN_KEY = new System.Windows.Forms.Button();
            this.I_TB_SECRETACCESSKEY = new System.Windows.Forms.TextBox();
            this.I_TB_ACCESSKEY = new System.Windows.Forms.TextBox();
            this.I_TB_LOG = new System.Windows.Forms.TextBox();
            this.I_BTN_RECOGNITION = new System.Windows.Forms.Button();
            this.I_TIMER_UI = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.I_PB_MAIN)).BeginInit();
            this.I_GB_CAMERA.SuspendLayout();
            this.I_GB_FACE.SuspendLayout();
            this.SuspendLayout();
            // 
            // I_PB_MAIN
            // 
            this.I_PB_MAIN.Location = new System.Drawing.Point(12, 12);
            this.I_PB_MAIN.Name = "I_PB_MAIN";
            this.I_PB_MAIN.Size = new System.Drawing.Size(680, 480);
            this.I_PB_MAIN.TabIndex = 0;
            this.I_PB_MAIN.TabStop = false;
            // 
            // I_GB_CAMERA
            // 
            this.I_GB_CAMERA.Controls.Add(this.I_BTN_START);
            this.I_GB_CAMERA.Controls.Add(this.I_BTN_REFRESH);
            this.I_GB_CAMERA.Controls.Add(this.I_CB_CAMERA);
            this.I_GB_CAMERA.Location = new System.Drawing.Point(699, 13);
            this.I_GB_CAMERA.Name = "I_GB_CAMERA";
            this.I_GB_CAMERA.Size = new System.Drawing.Size(235, 82);
            this.I_GB_CAMERA.TabIndex = 1;
            this.I_GB_CAMERA.TabStop = false;
            this.I_GB_CAMERA.Text = "Device";
            // 
            // I_BTN_START
            // 
            this.I_BTN_START.Location = new System.Drawing.Point(7, 47);
            this.I_BTN_START.Name = "I_BTN_START";
            this.I_BTN_START.Size = new System.Drawing.Size(215, 23);
            this.I_BTN_START.TabIndex = 3;
            this.I_BTN_START.Text = "Start";
            this.I_BTN_START.UseVisualStyleBackColor = true;
            this.I_BTN_START.Click += new System.EventHandler(this.I_BTN_START_Click);
            // 
            // I_BTN_REFRESH
            // 
            this.I_BTN_REFRESH.Location = new System.Drawing.Point(202, 21);
            this.I_BTN_REFRESH.Name = "I_BTN_REFRESH";
            this.I_BTN_REFRESH.Size = new System.Drawing.Size(20, 20);
            this.I_BTN_REFRESH.TabIndex = 2;
            this.I_BTN_REFRESH.Text = "R";
            this.I_BTN_REFRESH.UseVisualStyleBackColor = true;
            this.I_BTN_REFRESH.Click += new System.EventHandler(this.I_BTN_REFRESH_Click);
            // 
            // I_CB_CAMERA
            // 
            this.I_CB_CAMERA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.I_CB_CAMERA.FormattingEnabled = true;
            this.I_CB_CAMERA.Location = new System.Drawing.Point(7, 21);
            this.I_CB_CAMERA.Name = "I_CB_CAMERA";
            this.I_CB_CAMERA.Size = new System.Drawing.Size(189, 20);
            this.I_CB_CAMERA.TabIndex = 0;
            // 
            // I_GB_FACE
            // 
            this.I_GB_FACE.Controls.Add(this.label2);
            this.I_GB_FACE.Controls.Add(this.label1);
            this.I_GB_FACE.Controls.Add(this.I_BTN_KEY);
            this.I_GB_FACE.Controls.Add(this.I_TB_SECRETACCESSKEY);
            this.I_GB_FACE.Controls.Add(this.I_TB_ACCESSKEY);
            this.I_GB_FACE.Controls.Add(this.I_TB_LOG);
            this.I_GB_FACE.Controls.Add(this.I_BTN_RECOGNITION);
            this.I_GB_FACE.Location = new System.Drawing.Point(699, 102);
            this.I_GB_FACE.Name = "I_GB_FACE";
            this.I_GB_FACE.Size = new System.Drawing.Size(234, 390);
            this.I_GB_FACE.TabIndex = 2;
            this.I_GB_FACE.TabStop = false;
            this.I_GB_FACE.Text = "FaceRecognition";
            // 
            // I_BTN_KEY
            // 
            this.I_BTN_KEY.Location = new System.Drawing.Point(184, 21);
            this.I_BTN_KEY.Name = "I_BTN_KEY";
            this.I_BTN_KEY.Size = new System.Drawing.Size(37, 48);
            this.I_BTN_KEY.TabIndex = 3;
            this.I_BTN_KEY.Text = "Set";
            this.I_BTN_KEY.UseVisualStyleBackColor = true;
            this.I_BTN_KEY.Click += new System.EventHandler(this.I_BTN_KEY_Click);
            // 
            // I_TB_SECRETACCESSKEY
            // 
            this.I_TB_SECRETACCESSKEY.Location = new System.Drawing.Point(53, 48);
            this.I_TB_SECRETACCESSKEY.Name = "I_TB_SECRETACCESSKEY";
            this.I_TB_SECRETACCESSKEY.Size = new System.Drawing.Size(125, 21);
            this.I_TB_SECRETACCESSKEY.TabIndex = 2;
            // 
            // I_TB_ACCESSKEY
            // 
            this.I_TB_ACCESSKEY.Location = new System.Drawing.Point(53, 21);
            this.I_TB_ACCESSKEY.Name = "I_TB_ACCESSKEY";
            this.I_TB_ACCESSKEY.Size = new System.Drawing.Size(125, 21);
            this.I_TB_ACCESSKEY.TabIndex = 2;
            // 
            // I_TB_LOG
            // 
            this.I_TB_LOG.Location = new System.Drawing.Point(7, 104);
            this.I_TB_LOG.Multiline = true;
            this.I_TB_LOG.Name = "I_TB_LOG";
            this.I_TB_LOG.Size = new System.Drawing.Size(215, 280);
            this.I_TB_LOG.TabIndex = 1;
            // 
            // I_BTN_RECOGNITION
            // 
            this.I_BTN_RECOGNITION.Location = new System.Drawing.Point(6, 75);
            this.I_BTN_RECOGNITION.Name = "I_BTN_RECOGNITION";
            this.I_BTN_RECOGNITION.Size = new System.Drawing.Size(215, 23);
            this.I_BTN_RECOGNITION.TabIndex = 0;
            this.I_BTN_RECOGNITION.Text = "Recognition";
            this.I_BTN_RECOGNITION.UseVisualStyleBackColor = true;
            this.I_BTN_RECOGNITION.Click += new System.EventHandler(this.I_BTN_RECOGNITION_Click);
            // 
            // I_TIMER_UI
            // 
            this.I_TIMER_UI.Interval = 50;
            this.I_TIMER_UI.Tick += new System.EventHandler(this.I_TIMER_UI_Tick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "A Key";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "S Key";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 504);
            this.Controls.Add(this.I_GB_FACE);
            this.Controls.Add(this.I_GB_CAMERA);
            this.Controls.Add(this.I_PB_MAIN);
            this.Name = "MainView";
            this.Text = "ProtoType";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainView_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.I_PB_MAIN)).EndInit();
            this.I_GB_CAMERA.ResumeLayout(false);
            this.I_GB_FACE.ResumeLayout(false);
            this.I_GB_FACE.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox I_PB_MAIN;
        private System.Windows.Forms.GroupBox I_GB_CAMERA;
        private System.Windows.Forms.Button I_BTN_START;
        private System.Windows.Forms.Button I_BTN_REFRESH;
        private System.Windows.Forms.ComboBox I_CB_CAMERA;
        private System.Windows.Forms.GroupBox I_GB_FACE;
        private System.Windows.Forms.TextBox I_TB_LOG;
        private System.Windows.Forms.Button I_BTN_RECOGNITION;
        private System.Windows.Forms.Timer I_TIMER_UI;
        private System.Windows.Forms.TextBox I_TB_SECRETACCESSKEY;
        private System.Windows.Forms.TextBox I_TB_ACCESSKEY;
        private System.Windows.Forms.Button I_BTN_KEY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

