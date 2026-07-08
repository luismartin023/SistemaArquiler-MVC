using SistemaGestionResidencial.Interfaces;
using SistemaGestionResidencial.Models;

namespace SistemaGestionResidencial.Controllers
{
    public class PagoController
    {
        private readonly IPagoRepository _pagoRepo;
        private readonly IContratoRepository _contratoRepo;

        public PagoController(IPagoRepository pagoRepo, IContratoRepository contratoRepo)
        {
            _pagoRepo = pagoRepo;
            _contratoRepo = contratoRepo;
        }

        public IEnumerable<Pago> Listar()
        {
            return _pagoRepo.ObtenerTodos();
        }

        public IEnumerable<Pago> ObtenerPagosPorContrato(int contratoId)
        {
            return _pagoRepo.ObtenerPagosPorContrato(contratoId);
        }

        public void Agregar(Pago pago)
        {
            if (pago == null)
                throw new ArgumentNullException(nameof(pago));

            // Validar que no exista pago del mes
            if (_pagoRepo.PagoMesRegistrado(pago.ContratoId, pago.FechaPago.Month, pago.FechaPago.Year))
            {
                throw new ArgumentException("Ya existe un pago registrado para este mes");
            }

            // Validar monto completo
            var contrato = _contratoRepo.ObtenerPorId(pago.ContratoId);
            if (contrato == null)
            {
                throw new ArgumentException("El contrato especificado no existe");
            }

            if (pago.Monto < contrato.MontoMensual)
            {
                throw new ArgumentException($"El monto del pago ({pago.Monto}) no puede ser menor al monto mensual del contrato ({contrato.MontoMensual})");
            }

            _pagoRepo.Agregar(pago);
        }

        public void Actualizar(Pago pago)
        {
            if (pago == null)
                throw new ArgumentNullException(nameof(pago));

            _pagoRepo.Actualizar(pago);
        }

        public void Eliminar(int id)
        {
            _pagoRepo.Eliminar(id);
        }
    }
}
