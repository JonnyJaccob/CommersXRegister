using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ProyectoPoo
{
    [Serializable]
    class Cargar<T>
    {
        
            /*int Guardar()
            {
                try
                {
                    using (System.Windows.Forms.OpenFileDialog dialogo = new System.Windows.Forms.OpenFileDialog())
                    {
                        if (dialogo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            using (Stream st = File.Open(dialogo.FileName, FileMode.OpenOrCreate))
                            {
                                var B = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                                B.Serialize(st, this);
                                return 0;
                            }

                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
                catch (Exception)
                {
                    return 2;
                }
            }*/

        }
    }

