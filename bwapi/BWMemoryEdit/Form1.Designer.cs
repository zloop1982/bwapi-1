﻿namespace BWMemoryEdit
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.compareBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.compareGrid = new System.Windows.Forms.PropertyGrid();
            this.editorGrid = new System.Windows.Forms.PropertyGrid();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.offsetTabs = new System.Windows.Forms.TabControl();
            this.unitTab = new System.Windows.Forms.TabPage();
            this.spriteTab = new System.Windows.Forms.TabPage();
            this.unitList = new System.Windows.Forms.ListBox();
            this.spriteList = new System.Windows.Forms.ListBox();
            this.imageTab = new System.Windows.Forms.TabPage();
            this.imageList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.offsetTabs.SuspendLayout();
            this.unitTab.SuspendLayout();
            this.spriteTab.SuspendLayout();
            this.imageTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.offsetTabs);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(974, 460);
            this.splitContainer1.SplitterDistance = 299;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(671, 460);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.compareBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(665, 29);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // compareBtn
            // 
            this.compareBtn.AutoSize = true;
            this.compareBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.compareBtn.Location = new System.Drawing.Point(3, 3);
            this.compareBtn.Name = "compareBtn";
            this.compareBtn.Size = new System.Drawing.Size(59, 23);
            this.compareBtn.TabIndex = 0;
            this.compareBtn.Text = "Compare";
            this.compareBtn.UseVisualStyleBackColor = true;
            this.compareBtn.Click += new System.EventHandler(this.compareBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.compareGrid, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.editorGrid, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(665, 419);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // compareGrid
            // 
            this.compareGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compareGrid.HelpVisible = false;
            this.compareGrid.Location = new System.Drawing.Point(335, 3);
            this.compareGrid.Name = "compareGrid";
            this.compareGrid.Size = new System.Drawing.Size(327, 413);
            this.compareGrid.TabIndex = 2;
            this.compareGrid.ToolbarVisible = false;
            // 
            // editorGrid
            // 
            this.editorGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editorGrid.HelpVisible = false;
            this.editorGrid.Location = new System.Drawing.Point(3, 3);
            this.editorGrid.Name = "editorGrid";
            this.editorGrid.Size = new System.Drawing.Size(326, 413);
            this.editorGrid.TabIndex = 1;
            this.editorGrid.ToolbarVisible = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 40;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // offsetTabs
            // 
            this.offsetTabs.Controls.Add(this.unitTab);
            this.offsetTabs.Controls.Add(this.spriteTab);
            this.offsetTabs.Controls.Add(this.imageTab);
            this.offsetTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.offsetTabs.Location = new System.Drawing.Point(0, 0);
            this.offsetTabs.Name = "offsetTabs";
            this.offsetTabs.SelectedIndex = 0;
            this.offsetTabs.Size = new System.Drawing.Size(299, 460);
            this.offsetTabs.TabIndex = 0;
            // 
            // unitTab
            // 
            this.unitTab.Controls.Add(this.unitList);
            this.unitTab.Location = new System.Drawing.Point(4, 22);
            this.unitTab.Name = "unitTab";
            this.unitTab.Padding = new System.Windows.Forms.Padding(3);
            this.unitTab.Size = new System.Drawing.Size(291, 434);
            this.unitTab.TabIndex = 0;
            this.unitTab.Text = "Units";
            this.unitTab.UseVisualStyleBackColor = true;
            // 
            // spriteTab
            // 
            this.spriteTab.Controls.Add(this.spriteList);
            this.spriteTab.Location = new System.Drawing.Point(4, 22);
            this.spriteTab.Name = "spriteTab";
            this.spriteTab.Padding = new System.Windows.Forms.Padding(3);
            this.spriteTab.Size = new System.Drawing.Size(291, 434);
            this.spriteTab.TabIndex = 1;
            this.spriteTab.Text = "Sprites";
            this.spriteTab.UseVisualStyleBackColor = true;
            // 
            // unitList
            // 
            this.unitList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitList.FormattingEnabled = true;
            this.unitList.Location = new System.Drawing.Point(3, 3);
            this.unitList.Name = "unitList";
            this.unitList.Size = new System.Drawing.Size(285, 428);
            this.unitList.TabIndex = 1;
            // 
            // spriteList
            // 
            this.spriteList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spriteList.FormattingEnabled = true;
            this.spriteList.Location = new System.Drawing.Point(3, 3);
            this.spriteList.Name = "spriteList";
            this.spriteList.Size = new System.Drawing.Size(285, 428);
            this.spriteList.TabIndex = 2;
            // 
            // imageTab
            // 
            this.imageTab.Controls.Add(this.imageList);
            this.imageTab.Location = new System.Drawing.Point(4, 22);
            this.imageTab.Name = "imageTab";
            this.imageTab.Padding = new System.Windows.Forms.Padding(3);
            this.imageTab.Size = new System.Drawing.Size(291, 434);
            this.imageTab.TabIndex = 2;
            this.imageTab.Text = "Images";
            this.imageTab.UseVisualStyleBackColor = true;
            // 
            // imageList
            // 
            this.imageList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageList.FormattingEnabled = true;
            this.imageList.Location = new System.Drawing.Point(3, 3);
            this.imageList.Name = "imageList";
            this.imageList.Size = new System.Drawing.Size(285, 428);
            this.imageList.TabIndex = 3;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 460);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainWindow";
            this.Text = "BW Memory Editor";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.offsetTabs.ResumeLayout(false);
            this.unitTab.ResumeLayout(false);
            this.spriteTab.ResumeLayout(false);
            this.imageTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button compareBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PropertyGrid editorGrid;
        private System.Windows.Forms.PropertyGrid compareGrid;
        private System.Windows.Forms.TabControl offsetTabs;
        private System.Windows.Forms.TabPage unitTab;
        private System.Windows.Forms.ListBox unitList;
        private System.Windows.Forms.TabPage spriteTab;
        private System.Windows.Forms.ListBox spriteList;
        private System.Windows.Forms.TabPage imageTab;
        private System.Windows.Forms.ListBox imageList;
    }
}

