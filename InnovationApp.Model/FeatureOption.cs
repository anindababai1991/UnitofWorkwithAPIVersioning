namespace InnovationApp.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class FeatureOption
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FeatureOption()
        {
            TemplateFeatures = new HashSet<TemplateFeature>();
        }

        [Key]
        public int FeatureOptionsId { get; set; }

        [Required]
        [StringLength(50)]
        public string FeatureOptionsName { get; set; }

        public int RootFeatureId { get; set; }

        public int? OptionTypeId { get; set; }

        public int? OrderId { get; set; }

        public virtual FeatureOptionType FeatureOptionType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TemplateFeature> TemplateFeatures { get; set; }
    }
}
