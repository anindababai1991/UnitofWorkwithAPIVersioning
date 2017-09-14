namespace InnovationApp.DAL
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class MasterFeature
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MasterFeature()
        {
            TemplateDetails = new HashSet<TemplateDetail>();
        }

        [Key]
        public int FeatureId { get; set; }

        [StringLength(500)]
        public string Feature { get; set; }

        public int? OrderID { get; set; }

        public int? OptionTypeId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TemplateDetail> TemplateDetails { get; set; }
    }
}
