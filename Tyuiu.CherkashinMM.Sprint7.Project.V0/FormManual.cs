using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.CherkashinMM.Sprint7.Project.V0
{
    public partial class FormManual : Form
    {
        private int slide = 0;
        private string[] headers = { "Создание/открытие файла", "Сохранение/выход из файла", "Меню редактирования", "Взаимодействие с таблицей и данные", "Поиск", "Инструменты" };
        private string[] texts = {
            "Чтобы открыть или открыть файл, нажмите на кнопку \"Файл\" слева сверху.\nТам вы можете выбрать \"Создать файл\" или \"Открыть файл\"\nТакже вы можете создать файл комбинацией клавиш CTRL+N или открыть CTRL+O.",
            "Чтобы сохранить или выйти из файла, нажмите на кнопку \"Файл\" слева сверху.\nТам вы можете \"Сохранить\" файл, \"Сохранить как\", или \"Выйти\" из файла без сохранения\nСохранить файл вы можете комбинацией клавиш CTRL+S или CTRL+SHIFT+S.",
            "В меню редактирования вы можете увидеть следующие кнопки:\r\n1. Сбросить файл (F4). Сбрасывает файл до изначального состояния.\r\n2. Сортировка. Сортирует таблицу по выбранному столбцу и в выбранном порядке.\r\n3. Обновить статистику (F5). Обновляет статистику, учитывая внесенные изменения.\r\n4. Выделить всё (CTRL+A). Выделяет всю таблицу.\r\n5. Удалить выбранное (Del). Удаляет выбранные ячейки.\r\n6. Расширенный поиск (CTRL+F). Поиск по столбцу и значению.\r\n",
            "Вы можете увидеть статистику по продажам и общую статистику по количеству проданных товаров, выручке, средней цене товара, самому популярному товару и наименее популярному товару.\nТакже вы можете взаимодействовать с таблицей:\n - Сортировать её, нажав на заголовок столбца;\n - Удалять строки, нажав на соответсвующий значок в первом столбце любой строки;\n - Редактировать любую ячейку таблицы.",
            "Здесь вы можете ввести ключевые слова, а затем нажать на одну из кнопок:\n1. Поднимает наверх таблицы найденные значения и выделяет их.\n2. Удаляет все строки, кроме найденных.",
            "Здесь вы можете взаимодействовать с таблицей:\r\n1. Расширенный поиск. Ищите значения в конкретной яйчейке\r\nи с конкретным значением.\r\n2. Сортировка. Отсортируйте таблицу по выбранному столбцу \r\nв выбранном порядке.\r\n3. Добавить строку. Добавьте новую строку для клиента.\r\n4. Обновить статистику. Обновите статистику после изменения\r\nтаблицы.\r\n5. Сбросить файл до изначального состояния. Сбросьте файл\r\nдо изначального состояния, если вы не хотите его сохранять."
        };

        public FormManual()
        {
            InitializeComponent();

            groupBoxLabel_CMM.Text = headers[slide];
            labelInfo_CMM.Text = texts[slide];
            pictureBox1_1_CMM.Visible = true;
            pictureBox1_2_CMM.Visible = true;
        }

        private void buttonNext_CMM_Click(object sender, EventArgs e)
        {
            slide++;
            switch (slide)
            {
                case 1:
                    pictureBox1_1_CMM.Visible = false;
                    pictureBox1_2_CMM.Visible = false;
                    pictureBox2_CMM.Visible = true;
                    break;
                case 2:
                    pictureBox2_CMM.Visible = false;
                    pictureBox3_CMM.Visible = true;
                    break;
                case 3:
                    pictureBox3_CMM.Visible = false;
                    pictureBox4_CMM.Visible = true;
                    break;
                case 4:
                    pictureBox4_CMM.Visible = false;
                    pictureBox5_CMM.Visible = true;
                    break;
                case 5:
                    pictureBox5_CMM.Visible = false;
                    pictureBox6_CMM.Visible = true;
                    pictureBoxSearch_CMM.Visible = true;
                    pictureBoxSort_CMM.Visible = true;
                    buttonNext_CMM.Text = "Выход";
                    break;
                case 6:
                    this.Close();
                    return;
            }
            groupBoxLabel_CMM.Text = headers[slide];
            labelInfo_CMM.Text = texts[slide];
        }

        private void labelInfo_CMM_Click(object sender, EventArgs e)
        {

        }
    }
}
