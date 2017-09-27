using System;
using System.Collections.Generic;

namespace GeradorDesculpas.Mobile.Util
{
    public class Gerador
    {
        #region Arrays

        private static readonly List<string> Problemas = new List<string>
        {
            "O panelaço é ",
            "As vaias são ",
            "As manifestações são ",
            "Os protestos são ",
            "A crise é ",
            "Os pedalinhos são ",
            "O impeachment é ",
            "A alta do dólar é ",
            "As delações premiadas são ",
            "A operação lava-jato é ",
            "Os ataques à Petrobras são ",
            "Os grampos telefônicos são ",
            "O sítio de Atibaia é ",
            "O triplex é ",
            "Os altos índices de rejeição do governo são "
        };

        private static readonly List<string> Natureza = new List<string>
        {
            "uma invenção ",
            "uma estratégia ",
            "uma manobra ",
            "um crime ",
            "um complô ",
            "uma bandeira ",
            "uma falácia ",
            "um golpe ",
            "um ataque ",
            "uma ação ",
            "uma manipulação ",
            "um teoria ",
            "um ato de ódio ",
            "uma tática "
        };

        private static readonly List<string> Culpado = new List<string>
        {
            "do FHC ",
            "da Republica de Curitiba ",
            "da Joice Hasselmann ",
            "do Rodrigo Constantino ",
            "do Reginaldo Azevedo ",
            "do Marco Antonio Villa ",
            "do Delcídio ",
            "do Nestor Cerveró ",
            "do Gilmar Mendes ",
            "do Antagonista ",
            "do Eduardo Cunha ",
            "do PMBD ",
            "do Michel Temer ",
            "dos almofadinhas ",
            "da elite branca ",
            "do PIG ",
            "da oposição ",
            "do Olavo de Carvalho ",
            "dos coxinhas ",
            "da mídia golpista ",
            "do PSDB ",
            "da direita fascista ",
            "da VEJA ",
            "dos burgueses ",
            "do capitalismo selvagem ",
            "do Lobão ",
            "da Rede Globo ",
            "do Juiz Sérgio Moro ",
            "dos Estados Unidos ",
            "do TCU ",
            "do Danilo Gentili ",
            "do Ministério Público ",
            "da PF "
        };

        private static readonly List<string> Motivo = new List<string>
        {
            "para ameaçar ",
            "para desorganizar ",
            "para desmoralizar ",
            "para desestabilizar ",
            "para deslegitimizar ",
            "para destruir ",
            "para controlar ",
            "para subverter ",
            "para manipular ",
            "para desrespeitar ",
            "para oprimir ",
            "para prejudicar ",
            "para destituir "
        };

        private static readonly List<string> Vitima = new List<string>
        {
            "a presidenta!",
            "os movimentos sociais!",
            "os avanços da democracia!",
            "o Estado democrático de direito!",
            "as conquistas do trabalhadores!",
            "a defesa da democracia!",
            "a Constituição!",
            "o PT!",
            "a CUT!",
            "os companheiros e companheiras!",
            "os discursos da presidenta!",
            "o Lula!",
            "a mandioca!",
            "a Mulher-Sapiens!",
            "os pobres!",
            "as minorias!",
            "os direitos dos trabalhadores!",
            "a pátria educadora!",
            "a presidência da república!",
            "o resultado das urnas!"
        };

        #endregion

        private static string Aleatorio(IReadOnlyList<string> lista)
        {
            var valorMaximo = lista.Count;
            var random = new Random();
            var index = random.Next(0, valorMaximo);

            return lista[index];
        }

        public static string GerarDesculpa()
        {
            return Aleatorio(Problemas) + Aleatorio(Natureza) + Aleatorio(Culpado) + Aleatorio(Motivo) + Aleatorio(Vitima);

            //return "";
        }
    }
}