namespace InnovationApp.DAL
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("FeatureOptionType")]
    public partial class FeatureOptionType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FeatureOptionType()
        {
            FeatureOptions = new HashSet<FeatureOption>();
        }

        [Key]
        public int OptionTypeId { get; set; }

        [Required]
        [StringLength(30)]
        public string OptionTypeName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FeatureOption> FeatureOptions { get; set; }
    }
}
