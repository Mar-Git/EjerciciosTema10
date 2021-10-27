using System;//using en java se corresponde con importar
using System.ComponentModel;
using System.Runtime.CompilerServices;
//como añadir una propiedad nombre (que contenga un atributo privado) que tenga get
namespace Models
{
    public class clsPersona : INotifyPropertyChanged
    {
        #region atributos privados
        private string nombre;  // field (atributo)
        private string apellido;

        public event PropertyChangedEventHandler PropertyChanged;
        //INotifyPropertyChanged comunica el cambio a la vista
        #endregion

        #region propiedades publicas
        //public string Nombre { get => nombre; set => nombre = value; }//seria una de las formas de obtener las propiedades de nombre
        // public string Apellido { get => apellido; set => apellido = value; }
        //otra forma
        public string Nombre   // property
        {
            get { return nombre; }   // get method
            // set method
            set
            { 
                if (value.Contains("n"))
                {
                    apellido = "";
                    NotifyPropertyChanged("Apellido");//el campo publico que ha recibido el setter
                }
                nombre = value;
                
            }  
            
        }
        public string Apellido   // property
        {
            get { return apellido; }   // get method
            // set method
            set
            {
                if (value.Contains("n"))
                {
                    nombre = "";
                    NotifyPropertyChanged("Nombre");
                }
                apellido = value; 
            }  
        }
        /*
        //otra forma
        public int MyProperty { get; set; }//escribir prop y tabular 2 veces para que salga; propiedades autoimplementadas
        //crea solo el atributo, no hace falta ponerselo, ya esta incluido dentro.
        //si queremos meter una validacion en el get o en el set no se puede, hay que hacerlo de las otras formas
        */
        #endregion

        #region constructor
        //constructor por defecto
        public clsPersona()
        {
            nombre = "";
            apellido = "";
        }
        //constructor con parámetros
        public clsPersona(String nombre, String apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        #endregion
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
