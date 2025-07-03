using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementosGraficosMAUI.Dibujables
{
    internal class DibujoReloj : IDrawable
    {
        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            DateTime tiempoActual = DateTime.Now;
            PointF centroReloj = new PointF(200,300);
            int radioCirculo = 200;

            canvas.StrokeColor = Colors.Aqua;
            canvas.StrokeSize = 10;

            canvas.DrawCircle(centroReloj, radioCirculo);
            canvas.DrawCircle(centroReloj, 5);

            canvas.StrokeSize = 5;
            var horero = GetManecillaHora(tiempoActual, radioCirculo, centroReloj);
            canvas.DrawLine(centroReloj,horero);
            var minutero = GetManecillaMinuto(tiempoActual, radioCirculo, centroReloj);
            canvas.DrawLine(centroReloj, minutero);
            var segundero = GetManecillaSegundo(tiempoActual, radioCirculo, centroReloj);
            canvas.StrokeColor = Colors.Red;
            canvas.DrawLine(centroReloj, segundero);
        }

        private PointF GetManecillaSegundo(DateTime tiempoActual, int radioCirculo, PointF centroReloj)
        {
            int segundoActual = tiempoActual.Second;
            var anguloGrad = segundoActual * 360 / 60; // Cada segundo son 6 grados
            var anguloRad = Math.PI * anguloGrad / 180; // Convertir a radianes
            PointF extremoManecilla = new PointF((float)(radioCirculo * 0.9f * Math.Sin(anguloRad)) + centroReloj.X, (float)(-radioCirculo * 0.9f * Math.Cos(anguloRad)) + centroReloj.Y);
            return extremoManecilla;
        }

        private PointF GetManecillaMinuto(DateTime tiempoActual, int radioCirculo, PointF centroReloj)
        {
            int minutoActual = tiempoActual.Minute;
            var anguloGrad = minutoActual * 360 / 60; // Cada minuto son 6 grados
            var anguloRad = Math.PI * anguloGrad / 180; // Convertir a radianes
            PointF extremoManecilla = new PointF((float)(radioCirculo * 0.8f * Math.Sin(anguloRad)) + centroReloj.X, (float)(-radioCirculo * 0.8f * Math.Cos(anguloRad)) + centroReloj.Y);
            return extremoManecilla;
        }

        private PointF GetManecillaHora(DateTime tiempoActual, int radioCirculo, PointF centroReloj)
        {
            int horaActual = tiempoActual.Hour; // 4, 7, 10, 13, 16, 21, 22 
            if (horaActual > 12) horaActual -= 12; // Convertir a formato de 12 horas
            var anguloGrad = horaActual * 360 / 12; // Cada hora son 30 grados
            var anguloRad = Math.PI * anguloGrad / 180; // Convertir a radianes

            var longitudHorero = radioCirculo * 0.5f; // Longitud de la manecilla de la hora
            PointF extremoManecilla = new PointF((float)(longitudHorero* Math.Sin(anguloRad)) + centroReloj.X, (float)(-longitudHorero * Math.Cos(anguloRad)) + centroReloj.Y);
            return extremoManecilla;
        }
    }
}
