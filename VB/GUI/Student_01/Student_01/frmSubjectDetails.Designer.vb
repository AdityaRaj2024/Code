<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubjectDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim TreeNode103 As TreeNode = New TreeNode("Communicative English")
        Dim TreeNode104 As TreeNode = New TreeNode("Basic Mathematics")
        Dim TreeNode105 As TreeNode = New TreeNode("Information Technology & Application")
        Dim TreeNode106 As TreeNode = New TreeNode("Principles of Management & Organisation")
        Dim TreeNode107 As TreeNode = New TreeNode("Python Programming")
        Dim TreeNode108 As TreeNode = New TreeNode("First Semester", New TreeNode() {TreeNode103, TreeNode104, TreeNode105, TreeNode106, TreeNode107})
        Dim TreeNode109 As TreeNode = New TreeNode("Business English")
        Dim TreeNode110 As TreeNode = New TreeNode("Numerical Mathematics")
        Dim TreeNode111 As TreeNode = New TreeNode("System Analysis & Design")
        Dim TreeNode112 As TreeNode = New TreeNode("C Programming")
        Dim TreeNode113 As TreeNode = New TreeNode("Operating System & Unix")
        Dim TreeNode114 As TreeNode = New TreeNode("Second Semester", New TreeNode() {TreeNode109, TreeNode110, TreeNode111, TreeNode112, TreeNode113})
        Dim TreeNode115 As TreeNode = New TreeNode("FYBCA", New TreeNode() {TreeNode108, TreeNode114})
        Dim TreeNode116 As TreeNode = New TreeNode("OPPS using C++")
        Dim TreeNode117 As TreeNode = New TreeNode("Web Designing")
        Dim TreeNode118 As TreeNode = New TreeNode("Software Engineering")
        Dim TreeNode119 As TreeNode = New TreeNode("JAVA Programming")
        Dim TreeNode120 As TreeNode = New TreeNode("Third Semester", New TreeNode() {TreeNode116, TreeNode117, TreeNode118, TreeNode119})
        Dim TreeNode121 As TreeNode = New TreeNode("Relational Database Management System")
        Dim TreeNode122 As TreeNode = New TreeNode("Digital Electronics")
        Dim TreeNode123 As TreeNode = New TreeNode("Data Structure & Algorithms")
        Dim TreeNode124 As TreeNode = New TreeNode("Introduction To Statistics")
        Dim TreeNode125 As TreeNode = New TreeNode("Fourth Semester", New TreeNode() {TreeNode121, TreeNode122, TreeNode123, TreeNode124})
        Dim TreeNode126 As TreeNode = New TreeNode("SYBCA", New TreeNode() {TreeNode120, TreeNode125})
        Dim TreeNode127 As TreeNode = New TreeNode("VB . net")
        Dim TreeNode128 As TreeNode = New TreeNode("Graphics & Multimedia")
        Dim TreeNode129 As TreeNode = New TreeNode("Computer Network")
        Dim TreeNode130 As TreeNode = New TreeNode("Business Accounting & ERP")
        Dim TreeNode131 As TreeNode = New TreeNode("Fifth Semester", New TreeNode() {TreeNode127, TreeNode128, TreeNode129, TreeNode130})
        Dim TreeNode132 As TreeNode = New TreeNode("Web Technology")
        Dim TreeNode133 As TreeNode = New TreeNode("E-Commerce")
        Dim TreeNode134 As TreeNode = New TreeNode("Project & Viva")
        Dim TreeNode135 As TreeNode = New TreeNode("Sixth Semester", New TreeNode() {TreeNode132, TreeNode133, TreeNode134})
        Dim TreeNode136 As TreeNode = New TreeNode("TYBCA", New TreeNode() {TreeNode131, TreeNode135})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSubjectDetails))
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        SplitContainer1 = New SplitContainer()
        trvSubjects = New TreeView()
        ToolStrip1 = New ToolStrip()
        ToolStripButton1 = New ToolStripButton()
        TabPage2 = New TabPage()
        FontDialog1 = New FontDialog()
        ToolStripButton2 = New ToolStripButton()
        ColorDialog1 = New ColorDialog()
        ToolStripButton3 = New ToolStripButton()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(766, 560)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(SplitContainer1)
        TabPage1.Location = New Point(4, 38)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(758, 518)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Core Subjects"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(3, 3)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(trvSubjects)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(ToolStrip1)
        SplitContainer1.Size = New Size(752, 512)
        SplitContainer1.SplitterDistance = 250
        SplitContainer1.TabIndex = 0
        ' 
        ' trvSubjects
        ' 
        trvSubjects.Dock = DockStyle.Fill
        trvSubjects.Location = New Point(0, 0)
        trvSubjects.Name = "trvSubjects"
        TreeNode103.Name = "nCEnglish"
        TreeNode103.Text = "Communicative English"
        TreeNode104.Name = "nMath"
        TreeNode104.Text = "Basic Mathematics"
        TreeNode105.Name = "nIT"
        TreeNode105.Text = "Information Technology & Application"
        TreeNode106.Name = "nPOM"
        TreeNode106.Text = "Principles of Management & Organisation"
        TreeNode107.Name = "nPython"
        TreeNode107.Text = "Python Programming"
        TreeNode108.Name = "nSem1"
        TreeNode108.Text = "First Semester"
        TreeNode109.Name = "nBEnglish"
        TreeNode109.Text = "Business English"
        TreeNode110.Name = "nNumMath"
        TreeNode110.Text = "Numerical Mathematics"
        TreeNode111.Name = "nSAD"
        TreeNode111.Text = "System Analysis & Design"
        TreeNode112.Name = "nC"
        TreeNode112.Text = "C Programming"
        TreeNode113.Name = "nOS"
        TreeNode113.Text = "Operating System & Unix"
        TreeNode114.Name = "nSem2"
        TreeNode114.Text = "Second Semester"
        TreeNode115.Name = "nFY"
        TreeNode115.Text = "FYBCA"
        TreeNode116.Name = "nC++"
        TreeNode116.Text = "OPPS using C++"
        TreeNode117.Name = "nWD"
        TreeNode117.Text = "Web Designing"
        TreeNode118.Name = "nSE"
        TreeNode118.Text = "Software Engineering"
        TreeNode119.Name = "nJAVA"
        TreeNode119.Text = "JAVA Programming"
        TreeNode120.Name = "nSem3"
        TreeNode120.Text = "Third Semester"
        TreeNode121.Name = "nDBMS"
        TreeNode121.Text = "Relational Database Management System"
        TreeNode122.Name = "nDE"
        TreeNode122.Text = "Digital Electronics"
        TreeNode123.Name = "nDS"
        TreeNode123.Text = "Data Structure & Algorithms"
        TreeNode124.Name = "nStat"
        TreeNode124.Text = "Introduction To Statistics"
        TreeNode125.Name = "nSem4"
        TreeNode125.Text = "Fourth Semester"
        TreeNode126.Name = "nSY"
        TreeNode126.Text = "SYBCA"
        TreeNode127.Name = "nVB"
        TreeNode127.Text = "VB . net"
        TreeNode128.Name = "nGp"
        TreeNode128.Text = "Graphics & Multimedia"
        TreeNode129.Name = "nCN"
        TreeNode129.Text = "Computer Network"
        TreeNode130.Name = "nBA"
        TreeNode130.Text = "Business Accounting & ERP"
        TreeNode131.Name = "nSem5"
        TreeNode131.Text = "Fifth Semester"
        TreeNode132.Name = "nWT"
        TreeNode132.Text = "Web Technology"
        TreeNode133.Name = "nEC"
        TreeNode133.Text = "E-Commerce"
        TreeNode134.Name = "nPV"
        TreeNode134.Text = "Project & Viva"
        TreeNode135.Name = "nSem6"
        TreeNode135.Text = "Sixth Semester"
        TreeNode136.Name = "nTY"
        TreeNode136.Text = "TYBCA"
        trvSubjects.Nodes.AddRange(New TreeNode() {TreeNode115, TreeNode126, TreeNode136})
        trvSubjects.Size = New Size(250, 512)
        trvSubjects.TabIndex = 0
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.ImageScalingSize = New Size(20, 20)
        ToolStrip1.Items.AddRange(New ToolStripItem() {ToolStripButton1, ToolStripButton2, ToolStripButton3})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(498, 28)
        ToolStrip1.TabIndex = 0
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' ToolStripButton1
        ' 
        ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text
        ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), Image)
        ToolStripButton1.ImageTransparentColor = Color.Magenta
        ToolStripButton1.Name = "ToolStripButton1"
        ToolStripButton1.Size = New Size(45, 25)
        ToolStripButton1.Text = "Font"
        ' 
        ' TabPage2
        ' 
        TabPage2.Location = New Point(4, 30)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(758, 526)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Electives"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' ToolStripButton2
        ' 
        ToolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text
        ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), Image)
        ToolStripButton2.ImageTransparentColor = Color.Magenta
        ToolStripButton2.Name = "ToolStripButton2"
        ToolStripButton2.Size = New Size(52, 25)
        ToolStripButton2.Text = "Color"
        ' 
        ' ToolStripButton3
        ' 
        ToolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), Image)
        ToolStripButton3.ImageTransparentColor = Color.Magenta
        ToolStripButton3.Name = "ToolStripButton3"
        ToolStripButton3.Size = New Size(29, 25)
        ToolStripButton3.Text = "ToolStripButton3"
        ' 
        ' frmSubjectDetails
        ' 
        AutoScaleDimensions = New SizeF(14F, 29F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(766, 560)
        Controls.Add(TabControl1)
        Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(5, 4, 5, 4)
        Name = "frmSubjectDetails"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Subject Details"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        SplitContainer1.Panel2.PerformLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents trvSubjects As TreeView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents ToolStripButton3 As ToolStripButton
End Class
