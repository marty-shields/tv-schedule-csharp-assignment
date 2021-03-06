using TVSchedule;
using System;
using Microsoft.Pex.Framework;

namespace TVSchedule
{
    /// <summary>A factory for TVSchedule.PeriodDrama instances</summary>
    public static partial class PeriodDramaFactory
    {
        /// <summary>A factory for TVSchedule.PeriodDrama instances</summary>
        [PexFactoryMethod(typeof(PeriodDrama))]
        public static PeriodDrama Create(
            string id_s,
            string title_s1,
            string desc_s2,
            int runTime_i,
            int ageRating_i1,
            string mainActor_s3,
            string supportingActor_s4,
            int periodDate_i2
        )
        {
            PeriodDrama periodDrama = new PeriodDrama(id_s, title_s1, desc_s2, runTime_i,
                                                      ageRating_i1, mainActor_s3, supportingActor_s4, periodDate_i2);
            return periodDrama;

            // TODO: Edit factory method of PeriodDrama
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
