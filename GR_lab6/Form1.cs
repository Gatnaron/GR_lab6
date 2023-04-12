using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.OpenGl;
using Tao.FreeGlut;
using Tao.Platform.Windows;

namespace GR_lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AnT.InitializeContexts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //инициализация GLUT
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);
            //отчистка окна
            Gl.glClearColor(255, 255, 255, 1);
            //установка порта вывода в соответствии с размерами элемента AnT
            Gl.glViewport(0, 0, AnT.Width, AnT.Height);
            //настройка проекции
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(45, (float)AnT.Width/(float)AnT.Height, 0.1, 200);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            //настройка параметров OpenGL для визуализации
            Gl.glEnable(Gl.GL_DEPTH_TEST);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();
            Gl.glColor3f(1.0f, 0, 0);
            Gl.glPushMatrix();
            Gl.glTranslated(0, 0, -6);
            Gl.glRotated(45, 1, 1, 0);
            //рисуем сферу с помощью библиотеки FreeGLUT
            Glut.glutWireSphere(2, 32, 32);
            Gl.glPopMatrix();
            Gl.glFlush();
            AnT.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();
            Gl.glColor3f(1.0f, 0, 0);
            Gl.glPushMatrix();
            Gl.glTranslated(0, 0, -6);
            Gl.glRotated(20, 0, 1, 0);
            //рисуем куб с помощью библиотеки FreeGLUT
            Glut.glutWireCube(3);
            Gl.glPopMatrix();
            Gl.glFlush();
            AnT.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();
            Gl.glColor3f(1.0f, 0, 0);
            Gl.glPushMatrix();
            Gl.glTranslated(-1, 0.8, -7);
            Gl.glRotated(30, 1, 1, 1);
            //рисуем цилиндр с помощью библиотеки FreeGLUT
            Glut.glutWireCylinder(1, 4, 40, 10);
            Gl.glPopMatrix();
            Gl.glFlush();
            AnT.Invalidate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();
            Gl.glColor3f(1.0f, 0, 0);
            Gl.glPushMatrix();
            Gl.glTranslated(0, 0, -7);
            Gl.glRotated(30, 0, 1, 1);
            //рисуем конус с помощью библиотеки FreeGLUT
            Glut.glutWireCone(2, 4, 40, 10);
            Gl.glPopMatrix();
            Gl.glFlush();
            AnT.Invalidate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();
            Gl.glColor3f(1.0f, 0, 0);
            Gl.glPushMatrix();
            Gl.glTranslated(0, 0, -7);
            Gl.glRotated(30, 0, 0, 0);
            //рисуем чайник с помощью библиотеки FreeGLUT
            Glut.glutWireTeapot(2);
            Gl.glPopMatrix();
            Gl.glFlush();
            AnT.Invalidate();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();
            Gl.glColor3f(1.0f, 0, 0);
            Gl.glPushMatrix();
            Gl.glTranslated(0, 0, -8);
            Gl.glRotated(30, 0, 1, 1);
            //рисуем пончик с помощью библиотеки FreeGLUT
            Glut.glutWireTorus(1, 2, 20, 40);
            Gl.glPopMatrix();
            Gl.glFlush();
            AnT.Invalidate();
        }
    }
}
