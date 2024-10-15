using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioscoInformaticoServices.Enums
{
    public enum CondicionIvaEnum
    {
        [Description("Persona o entidad responsable inscripta en el impuesto al valor agregado.")]
        Responsable_Inscripto,

        [Description("Persona o entidad responsable no inscripta en el impuesto al valor agregado.")]
        Responsable_NoInscripto,

        [Description("Persona o entidad exenta del impuesto al valor agregado.")]
        Exento,

        [Description("Persona o entidad no responsable del impuesto al valor agregado.")]
        No_Responsable,

        [Description("Consumidor final, no responsable del impuesto al valor agregado.")]
        Consumidor_Final,

        [Description("Persona o entidad monotributista.")]
        Monotributista,

        [Description("Sujeto no categorizado en el impuesto al valor agregado.")]
        Sujeto_NoCategorizado,

        [Description("No definido")]
        No_Definido
    }
}
