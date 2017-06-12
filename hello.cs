using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Windows.Forms;
using System.Drawing;

class HelloNeko : Form {

//  [STAThread]
  public static void Main() {
    GeneratedCodeAttribute generatedCodeAttribute =
        new GeneratedCodeAttribute(
           "Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0"
        );
    Application.EnableVisualStyles();
    Application.SetCompatibleTextRenderingDefault(false);
    Application.Run( new HelloNeko());
  }

  HelloNeko(){
    Text = "Button Click Sample";
    ClientSize = new Size(200, 200);
    Button btn1 = new Button();
    btn1.Location = new Point(50, 50);
    btn1.Text = "Click!";
    btn1.Click += btn1_Click;
    Controls.AddRange(new Control[] { btn1 });
  }

  void btn1_Click(object sender, System.EventArgs e) {
    MessageBox.Show("Hello .NEKO World", "‚±‚ñ‚¿‚í");
  }
}