using System;//using en java se corresponde con importar
//como añadir una propiedad nombre (que contenga un atributo privado) que tenga get
namespace Models
{
    public class clsPersona
    {
        #region atributos privados
        private string nombre;  // field (atributo)
        private string apellido;
        #endregion

        #region propiedades publicas
        public string Nombre { get => nombre; set => nombre = value; }//seria una de las formas de obtener las propiedades de nombre
        public string Apellido { get => apellido; set => apellido = value; }
        //otra forma
        /*public string Name   // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }
        
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
            Nombre = "Mar";
            Apellido = "Acal";
        }
        //constructor por parámetros
        public clsPersona(String nombre, String apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }
        #endregion

    }
}
