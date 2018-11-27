using MyLib.WF.Component;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MyRegularExpressionTest {
    public partial class MyRegularExpressionMainFrm : FormEx {

        #region Declaration
        private class Cst {
            public const int Padding = 3;
            public const int Margin = 10;
            public const int Offset = 12;
        }
        #endregion

        #region Constructor
        public MyRegularExpressionMainFrm() {
            InitializeComponent();
        }
        #endregion

        #region Form Event
        private void MyRegularExpressionMainFrm_Load(object sender, EventArgs e) {
            System.Reflection.Assembly assenbley = System.Reflection.Assembly.GetExecutingAssembly();
            //バージョンの取得
            this.Text = "正規表現確認(" + assenbley.GetName().Version + ")";
            this.adjustControl();

            string pattern = @"(\[car:)(?<carName>.+?)(\])";
            Regex reg = new Regex(pattern);
            string target = "[car:honda][car:atenza]";
            var match = reg.Matches(target);
            foreach (Match m in match) {
                string carName = m.Groups["carName"].Value;
            }

        }
        private void MyRegularExpressionMainFrm_Resize(object sender, EventArgs e) {
            this.adjustControl();
        }
        #endregion

        #region Control Event
        private void cExpression_TextChanged(object sender, EventArgs e) {
            this.showResult();
        }

        private void cTarget_TextChanged(object sender, EventArgs e) {
            this.cResult.Text = this.cTarget.Text;
            this.showResult();
        }

        private void cGroup_TextChanged(object sender, EventArgs e) {
            this.showResult();
        }
        #endregion

        #region Private Method
        /// <summary>
        /// adjust constrols for form
        /// </summary>
        private void adjustControl() {
            // マジックナンバーは実動作をみて調整した値(数値の根拠は不明)

            this.cExpressionBackground.Width = this.Width - (Cst.Offset * 2) - Cst.Offset;
            this.cExpression.Width = this.cExpressionBackground.Width - (Cst.Padding * 2);

            this.cGroupBackground.Width = this.cExpressionBackground.Width;
            this.cGroup.Width = this.cExpression.Width;

            this.cTargetBackground.Width = this.cExpressionBackground.Width;
            this.cTarget.Width = this.cExpression.Width;
            this.cResultBackground.Width = this.cExpressionBackground.Width;
            this.cResult.Width = this.cExpression.Width;

            int areaHeight = this.Height - this.cTargetBackground.Top - Cst.Margin - Cst.Margin - 40;
            int boxHeight = (int)(areaHeight / 2);

            this.cTargetBackground.Height = boxHeight;
            this.cTarget.Height = this.cTargetBackground.Height - (Cst.Padding * 2);
            this.cResultBackground.Height = this.cTargetBackground.Height;
            this.cResult.Height = this.cTarget.Height;

            this.cResultBackground.Top = this.Height - this.cResultBackground.Height - Cst.Margin - SystemInformation.CaptionHeight - 18;
        }

        /// <summary>
        /// show result
        /// </summary>
        private void showResult() {
            this.cResult.Select(0, this.cResult.Text.Length);
            this.cResult.SelectionBackColor = Color.White;
            this.cResult.SelectionColor = Color.Black;

            if (0 == this.cTarget.Text.Length) {
                return;
            }
            if (0 == this.cExpression.Text.Length) {
                return;
            }

            // https://msdn.microsoft.com/ja-jp/library/cc720850.aspx
            try {
                Regex reg = new Regex(this.cExpression.Text);

                string[] text = this.cTarget.Text.Split('\n');
                int readSize = 0;
                for (int i = 0; i < text.Length; i++) {
                    MatchCollection matches = reg.Matches(text[i]);
                    int index = 0;

                    foreach (Match match in matches) {
                        this.cResult.Select(readSize + match.Index, match.Length);
                        if (index % 2 == 0) {
                            this.cResult.SelectionBackColor = Color.LightPink;
                        }else {
                            this.cResult.SelectionBackColor = Color.LightGreen;
                        }


                        if (0 < this.cGroup.Text.Length) {
                            string groupVal = match.Groups[this.cGroup.Text].Value;
                            if (null != groupVal && 0 < groupVal.Length) {
                                int pos = this.cResult.SelectedText.IndexOf(groupVal);
                                this.cResult.Select(readSize + match.Index + pos, groupVal.Length);
                                this.cResult.SelectionColor = Color.Red;
                            }
                        }
                        index++;

                    }
                    readSize += text[i].Length + 1;
                }
                this.cResult.Select(0, 0);
            } catch (Exception ex) {
                // エスケープシーケンスの\の入力中等、不正な文字列としてエラーではじかれることがあるので例外は無視
            }
        }
        #endregion

    }
}
