using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade05
{
    class ConversaoDeUnidadesDeVolume
    {
        public static float LitrosParaCentimetrosCubicos(float litros)
        {
            return litros * 1000;
        }
        public static float MetrosCubicosParaLitros(float metrosCubicos)
        {
            return metrosCubicos * 1000;
        }
        public static float MetrosCubicosParaPesCubicos(float metrosCubicos)
        {
            return metrosCubicos * 35.32f;
        }
        public static float GaloesAmericanosParaPolegadasCubicas(float galoesAmericanos)
        {
            return galoesAmericanos * 231;
        }
        public static float GaloesAmericanosParaLitros(float galoesAmericanos)
        {
            return galoesAmericanos * 3.785f;
        }
    }
}
