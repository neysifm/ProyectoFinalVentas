namespace BLL
{
    public interface IFormularioRegistros<T>
    {
        bool ValidarCampos();
        bool ValidarBuscar();
        bool ValidarEliminar();
        bool ValidarGuardar();
        bool ValidarModificar();
        void LimpiarCampos();
        T LlenaClase();
        void LlenaCampos(T obj);
    }
}
