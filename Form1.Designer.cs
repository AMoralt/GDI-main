
namespace GDI
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
            this.panel = new System.Windows.Forms.Panel();
            this.Canvas = new System.Windows.Forms.Panel();
            this.pnlTools = new System.Windows.Forms.Panel();
            this.btnScale = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.btnColorInversion = new System.Windows.Forms.Button();
            this.btnIntersect = new System.Windows.Forms.Button();
            this.btnRotateFlip = new System.Windows.Forms.Button();
            this.btnDownloadImage = new System.Windows.Forms.Button();
            this.btnExclude = new System.Windows.Forms.Button();
            this.btnComplement = new System.Windows.Forms.Button();
            this.btnPointsArray = new System.Windows.Forms.Button();
            this.btnComb = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnGradientAlongThePath = new System.Windows.Forms.Button();
            this.btnInterpolation = new System.Windows.Forms.Button();
            this.btnGradientCenterPoint = new System.Windows.Forms.Button();
            this.btnRegion = new System.Windows.Forms.Button();
            this.btnGradient = new System.Windows.Forms.Button();
            this.btnTextPolygon = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnPolygons = new System.Windows.Forms.Button();
            this.btnPolygon = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnBezier = new System.Windows.Forms.Button();
            this.btnBeziers = new System.Windows.Forms.Button();
            this.btnEllipseSepment = new System.Windows.Forms.Button();
            this.btnDiagram = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.pnlTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.Canvas);
            this.panel.Controls.Add(this.pnlTools);
            this.panel.Location = new System.Drawing.Point(10, 10);
            this.panel.Margin = new System.Windows.Forms.Padding(1);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(799, 390);
            this.panel.TabIndex = 0;
            // 
            // Canvas
            // 
            this.Canvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Canvas.BackColor = System.Drawing.Color.White;
            this.Canvas.Location = new System.Drawing.Point(0, 0);
            this.Canvas.Margin = new System.Windows.Forms.Padding(2);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(404, 390);
            this.Canvas.TabIndex = 2;
            // 
            // pnlTools
            // 
            this.pnlTools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTools.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlTools.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTools.Controls.Add(this.btnScale);
            this.pnlTools.Controls.Add(this.btnImage);
            this.pnlTools.Controls.Add(this.btnColorInversion);
            this.pnlTools.Controls.Add(this.btnIntersect);
            this.pnlTools.Controls.Add(this.btnRotateFlip);
            this.pnlTools.Controls.Add(this.btnDownloadImage);
            this.pnlTools.Controls.Add(this.btnExclude);
            this.pnlTools.Controls.Add(this.btnComplement);
            this.pnlTools.Controls.Add(this.btnPointsArray);
            this.pnlTools.Controls.Add(this.btnComb);
            this.pnlTools.Controls.Add(this.btnSub);
            this.pnlTools.Controls.Add(this.btnGradientAlongThePath);
            this.pnlTools.Controls.Add(this.btnInterpolation);
            this.pnlTools.Controls.Add(this.btnGradientCenterPoint);
            this.pnlTools.Controls.Add(this.btnRegion);
            this.pnlTools.Controls.Add(this.btnGradient);
            this.pnlTools.Controls.Add(this.btnTextPolygon);
            this.pnlTools.Controls.Add(this.btnLine);
            this.pnlTools.Controls.Add(this.btnPolygons);
            this.pnlTools.Controls.Add(this.btnPolygon);
            this.pnlTools.Controls.Add(this.btnEllipse);
            this.pnlTools.Controls.Add(this.btnBezier);
            this.pnlTools.Controls.Add(this.btnBeziers);
            this.pnlTools.Controls.Add(this.btnEllipseSepment);
            this.pnlTools.Controls.Add(this.btnDiagram);
            this.pnlTools.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlTools.Location = new System.Drawing.Point(404, 0);
            this.pnlTools.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(393, 391);
            this.pnlTools.TabIndex = 1;
            // 
            // btnScale
            // 
            this.btnScale.Location = new System.Drawing.Point(251, 158);
            this.btnScale.Margin = new System.Windows.Forms.Padding(2);
            this.btnScale.Name = "btnScale";
            this.btnScale.Size = new System.Drawing.Size(119, 35);
            this.btnScale.TabIndex = 37;
            this.btnScale.Text = "Масштаб";
            this.btnScale.UseVisualStyleBackColor = true;
            this.btnScale.Click += new System.EventHandler(this.btnScale_Click);
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(251, 2);
            this.btnImage.Margin = new System.Windows.Forms.Padding(2);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(119, 35);
            this.btnImage.TabIndex = 36;
            this.btnImage.Text = "Изображение";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // btnColorInversion
            // 
            this.btnColorInversion.Location = new System.Drawing.Point(251, 119);
            this.btnColorInversion.Margin = new System.Windows.Forms.Padding(2);
            this.btnColorInversion.Name = "btnColorInversion";
            this.btnColorInversion.Size = new System.Drawing.Size(119, 35);
            this.btnColorInversion.TabIndex = 35;
            this.btnColorInversion.Text = "Инверсия цвета";
            this.btnColorInversion.UseVisualStyleBackColor = true;
            this.btnColorInversion.Click += new System.EventHandler(this.btnColorInversion_Click);
            // 
            // btnIntersect
            // 
            this.btnIntersect.Location = new System.Drawing.Point(125, 353);
            this.btnIntersect.Margin = new System.Windows.Forms.Padding(2);
            this.btnIntersect.Name = "btnIntersect";
            this.btnIntersect.Size = new System.Drawing.Size(119, 35);
            this.btnIntersect.TabIndex = 20;
            this.btnIntersect.Text = "Пересечение";
            this.btnIntersect.UseVisualStyleBackColor = true;
            this.btnIntersect.Click += new System.EventHandler(this.btnIntersect_Click);
            // 
            // btnRotateFlip
            // 
            this.btnRotateFlip.Location = new System.Drawing.Point(251, 80);
            this.btnRotateFlip.Margin = new System.Windows.Forms.Padding(2);
            this.btnRotateFlip.Name = "btnRotateFlip";
            this.btnRotateFlip.Size = new System.Drawing.Size(119, 35);
            this.btnRotateFlip.TabIndex = 28;
            this.btnRotateFlip.Text = "Поворот";
            this.btnRotateFlip.UseVisualStyleBackColor = true;
            this.btnRotateFlip.Click += new System.EventHandler(this.btnRotateFlip_Click);
            // 
            // btnDownloadImage
            // 
            this.btnDownloadImage.Location = new System.Drawing.Point(251, 41);
            this.btnDownloadImage.Margin = new System.Windows.Forms.Padding(2);
            this.btnDownloadImage.Name = "btnDownloadImage";
            this.btnDownloadImage.Size = new System.Drawing.Size(119, 35);
            this.btnDownloadImage.TabIndex = 29;
            this.btnDownloadImage.Text = "Загрузка изображения";
            this.btnDownloadImage.UseVisualStyleBackColor = true;
            this.btnDownloadImage.Click += new System.EventHandler(this.btnDownloadImage_Click);
            // 
            // btnExclude
            // 
            this.btnExclude.Location = new System.Drawing.Point(125, 314);
            this.btnExclude.Margin = new System.Windows.Forms.Padding(2);
            this.btnExclude.Name = "btnExclude";
            this.btnExclude.Size = new System.Drawing.Size(119, 35);
            this.btnExclude.TabIndex = 16;
            this.btnExclude.Text = "Исключение";
            this.btnExclude.UseVisualStyleBackColor = true;
            this.btnExclude.Click += new System.EventHandler(this.btnExclude_Click);
            // 
            // btnComplement
            // 
            this.btnComplement.Location = new System.Drawing.Point(125, 275);
            this.btnComplement.Margin = new System.Windows.Forms.Padding(2);
            this.btnComplement.Name = "btnComplement";
            this.btnComplement.Size = new System.Drawing.Size(119, 35);
            this.btnComplement.TabIndex = 17;
            this.btnComplement.Text = "Комплемент";
            this.btnComplement.UseVisualStyleBackColor = true;
            this.btnComplement.Click += new System.EventHandler(this.btnComplement_Click);
            // 
            // btnPointsArray
            // 
            this.btnPointsArray.Location = new System.Drawing.Point(125, 2);
            this.btnPointsArray.Margin = new System.Windows.Forms.Padding(2);
            this.btnPointsArray.Name = "btnPointsArray";
            this.btnPointsArray.Size = new System.Drawing.Size(119, 35);
            this.btnPointsArray.TabIndex = 10;
            this.btnPointsArray.Text = "Массив точек";
            this.btnPointsArray.UseVisualStyleBackColor = true;
            this.btnPointsArray.Click += new System.EventHandler(this.btnPointsArray_Click);
            // 
            // btnComb
            // 
            this.btnComb.Location = new System.Drawing.Point(125, 236);
            this.btnComb.Margin = new System.Windows.Forms.Padding(2);
            this.btnComb.Name = "btnComb";
            this.btnComb.Size = new System.Drawing.Size(119, 35);
            this.btnComb.TabIndex = 18;
            this.btnComb.Text = "Объединение";
            this.btnComb.UseVisualStyleBackColor = true;
            this.btnComb.Click += new System.EventHandler(this.btnComb_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(125, 197);
            this.btnSub.Margin = new System.Windows.Forms.Padding(2);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(119, 35);
            this.btnSub.TabIndex = 19;
            this.btnSub.Text = "Вычитание";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnGradientAlongThePath
            // 
            this.btnGradientAlongThePath.Location = new System.Drawing.Point(125, 41);
            this.btnGradientAlongThePath.Margin = new System.Windows.Forms.Padding(2);
            this.btnGradientAlongThePath.Name = "btnGradientAlongThePath";
            this.btnGradientAlongThePath.Size = new System.Drawing.Size(119, 35);
            this.btnGradientAlongThePath.TabIndex = 11;
            this.btnGradientAlongThePath.Text = "Градиент вдоль пути";
            this.btnGradientAlongThePath.UseVisualStyleBackColor = true;
            this.btnGradientAlongThePath.Click += new System.EventHandler(this.btnGradientAlongThePath_Click);
            // 
            // btnInterpolation
            // 
            this.btnInterpolation.Location = new System.Drawing.Point(125, 80);
            this.btnInterpolation.Margin = new System.Windows.Forms.Padding(2);
            this.btnInterpolation.Name = "btnInterpolation";
            this.btnInterpolation.Size = new System.Drawing.Size(119, 35);
            this.btnInterpolation.TabIndex = 12;
            this.btnInterpolation.Text = "Интерполяция цвета";
            this.btnInterpolation.UseVisualStyleBackColor = true;
            this.btnInterpolation.Click += new System.EventHandler(this.btnInterpolation_Click);
            // 
            // btnGradientCenterPoint
            // 
            this.btnGradientCenterPoint.Location = new System.Drawing.Point(125, 119);
            this.btnGradientCenterPoint.Margin = new System.Windows.Forms.Padding(2);
            this.btnGradientCenterPoint.Name = "btnGradientCenterPoint";
            this.btnGradientCenterPoint.Size = new System.Drawing.Size(119, 35);
            this.btnGradientCenterPoint.TabIndex = 15;
            this.btnGradientCenterPoint.Text = "Центр градиента";
            this.btnGradientCenterPoint.UseVisualStyleBackColor = true;
            this.btnGradientCenterPoint.Click += new System.EventHandler(this.btnGradientCenterPoint_Click);
            // 
            // btnRegion
            // 
            this.btnRegion.Location = new System.Drawing.Point(125, 158);
            this.btnRegion.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegion.Name = "btnRegion";
            this.btnRegion.Size = new System.Drawing.Size(119, 35);
            this.btnRegion.TabIndex = 13;
            this.btnRegion.Text = "Области";
            this.btnRegion.UseVisualStyleBackColor = true;
            this.btnRegion.Click += new System.EventHandler(this.btnRegion_Click);
            // 
            // btnGradient
            // 
            this.btnGradient.Location = new System.Drawing.Point(2, 353);
            this.btnGradient.Margin = new System.Windows.Forms.Padding(2);
            this.btnGradient.Name = "btnGradient";
            this.btnGradient.Size = new System.Drawing.Size(119, 35);
            this.btnGradient.TabIndex = 6;
            this.btnGradient.Text = "Градиент";
            this.btnGradient.UseVisualStyleBackColor = true;
            this.btnGradient.Click += new System.EventHandler(this.btnGradient_Click);
            // 
            // btnTextPolygon
            // 
            this.btnTextPolygon.Location = new System.Drawing.Point(2, 314);
            this.btnTextPolygon.Margin = new System.Windows.Forms.Padding(2);
            this.btnTextPolygon.Name = "btnTextPolygon";
            this.btnTextPolygon.Size = new System.Drawing.Size(119, 35);
            this.btnTextPolygon.TabIndex = 7;
            this.btnTextPolygon.Text = "Текст и Полигон";
            this.btnTextPolygon.UseVisualStyleBackColor = true;
            this.btnTextPolygon.Click += new System.EventHandler(this.btnTextPolygon_Click);
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(2, 2);
            this.btnLine.Margin = new System.Windows.Forms.Padding(2);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(119, 35);
            this.btnLine.TabIndex = 0;
            this.btnLine.Text = "Линия";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnPolygons
            // 
            this.btnPolygons.Location = new System.Drawing.Point(2, 275);
            this.btnPolygons.Margin = new System.Windows.Forms.Padding(2);
            this.btnPolygons.Name = "btnPolygons";
            this.btnPolygons.Size = new System.Drawing.Size(119, 35);
            this.btnPolygons.TabIndex = 8;
            this.btnPolygons.Text = "Полигоны";
            this.btnPolygons.UseVisualStyleBackColor = true;
            this.btnPolygons.Click += new System.EventHandler(this.btnPolygons_Click);
            // 
            // btnPolygon
            // 
            this.btnPolygon.Location = new System.Drawing.Point(2, 236);
            this.btnPolygon.Margin = new System.Windows.Forms.Padding(2);
            this.btnPolygon.Name = "btnPolygon";
            this.btnPolygon.Size = new System.Drawing.Size(119, 35);
            this.btnPolygon.TabIndex = 9;
            this.btnPolygon.Text = "Полигон";
            this.btnPolygon.UseVisualStyleBackColor = true;
            this.btnPolygon.Click += new System.EventHandler(this.btnPolygon_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.Location = new System.Drawing.Point(2, 41);
            this.btnEllipse.Margin = new System.Windows.Forms.Padding(2);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(119, 35);
            this.btnEllipse.TabIndex = 1;
            this.btnEllipse.Text = "Эллипс";
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnBezier
            // 
            this.btnBezier.Location = new System.Drawing.Point(2, 80);
            this.btnBezier.Margin = new System.Windows.Forms.Padding(2);
            this.btnBezier.Name = "btnBezier";
            this.btnBezier.Size = new System.Drawing.Size(119, 35);
            this.btnBezier.TabIndex = 2;
            this.btnBezier.Text = "Кривая Бельзе";
            this.btnBezier.UseVisualStyleBackColor = true;
            this.btnBezier.Click += new System.EventHandler(this.btnBezier_Click);
            // 
            // btnBeziers
            // 
            this.btnBeziers.Location = new System.Drawing.Point(2, 119);
            this.btnBeziers.Margin = new System.Windows.Forms.Padding(2);
            this.btnBeziers.Name = "btnBeziers";
            this.btnBeziers.Size = new System.Drawing.Size(119, 35);
            this.btnBeziers.TabIndex = 5;
            this.btnBeziers.Text = "Кривые Бельзе";
            this.btnBeziers.UseVisualStyleBackColor = true;
            this.btnBeziers.Click += new System.EventHandler(this.btnBeziers_Click);
            // 
            // btnEllipseSepment
            // 
            this.btnEllipseSepment.Location = new System.Drawing.Point(2, 158);
            this.btnEllipseSepment.Margin = new System.Windows.Forms.Padding(2);
            this.btnEllipseSepment.Name = "btnEllipseSepment";
            this.btnEllipseSepment.Size = new System.Drawing.Size(119, 35);
            this.btnEllipseSepment.TabIndex = 4;
            this.btnEllipseSepment.Text = "Сегмент Эллипса";
            this.btnEllipseSepment.UseVisualStyleBackColor = true;
            this.btnEllipseSepment.Click += new System.EventHandler(this.btnEllipseSepment_Click);
            // 
            // btnDiagram
            // 
            this.btnDiagram.Location = new System.Drawing.Point(2, 197);
            this.btnDiagram.Margin = new System.Windows.Forms.Padding(2);
            this.btnDiagram.Name = "btnDiagram";
            this.btnDiagram.Size = new System.Drawing.Size(119, 35);
            this.btnDiagram.TabIndex = 3;
            this.btnDiagram.Text = "Диаграмма";
            this.btnDiagram.UseVisualStyleBackColor = true;
            this.btnDiagram.Click += new System.EventHandler(this.btnDiagram_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(819, 409);
            this.Controls.Add(this.panel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel.ResumeLayout(false);
            this.pnlTools.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel pnlTools;
        private System.Windows.Forms.Button btnPolygon;
        private System.Windows.Forms.Button btnPolygons;
        private System.Windows.Forms.Button btnTextPolygon;
        private System.Windows.Forms.Button btnGradient;
        private System.Windows.Forms.Button btnBeziers;
        private System.Windows.Forms.Button btnEllipseSepment;
        private System.Windows.Forms.Button btnDiagram;
        private System.Windows.Forms.Button btnBezier;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnExclude;
        private System.Windows.Forms.Button btnComplement;
        private System.Windows.Forms.Button btnPointsArray;
        private System.Windows.Forms.Button btnComb;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnGradientAlongThePath;
        private System.Windows.Forms.Button btnInterpolation;
        private System.Windows.Forms.Button btnGradientCenterPoint;
        private System.Windows.Forms.Button btnRegion;
        private System.Windows.Forms.Button btnColorInversion;
        private System.Windows.Forms.Button btnIntersect;
        private System.Windows.Forms.Button btnRotateFlip;
        private System.Windows.Forms.Button btnDownloadImage;
        private System.Windows.Forms.Panel Canvas;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Button btnScale;
    }
}

