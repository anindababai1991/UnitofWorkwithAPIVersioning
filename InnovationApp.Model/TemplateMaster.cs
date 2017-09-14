namespace InnovationApp.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("TemplateMaster")]
    public partial class TemplateMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TemplateMaster()
        {
            TemplateDetails = new HashSet<TemplateDetail>();
            TemplateFeatures = new HashSet<TemplateFeature>();
        }

        [Key]
        public int TemplateId { get; set; }

        [Required]
        [StringLength(25)]
        public string TemplateName { get; set; }

        [Required]
        [StringLength(50)]
        public string CreatedBy { get; set; }

        public int UserId { get; set; }

        public DateTime CreatedOn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TemplateDetail> TemplateDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TemplateFeature> TemplateFeatures { get; set; }

        public virtual User User { get; set; }
    }
}
