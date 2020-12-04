using System;
using System.Collections.Generic;
using System.Windows;
using WPFBlitz.src;
using WPFBlitz.src.Montreal;

namespace WPFBlitz
{
    public static class Runner
    {      

        public static void Begin(List<Excel> excel)
        {
            try
            {
                var taskMontreal = new RunTasks();

                foreach (var data in excel)
                {
                    taskMontreal.Tasks(data.Cpf, data.dateLate, data.Erro);
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("" + error);
            }
        }
    }
}
