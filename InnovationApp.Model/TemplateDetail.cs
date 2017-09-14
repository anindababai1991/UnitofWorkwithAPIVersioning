namespace InnovationApp.DAL
{
    using System.ComponentModel.DataAnnotations;

    public partial class TemplateDetail
    {
        public int Id { get; set; }

        public int TemplateId { get; set; }

        public int? FeatureId { get; set; }

        [StringLength(50)]
        public string FeatureValues { get; set; }

        public virtual MasterFeature MasterFeature { get; set; }

        public virtual TemplateMaster TemplateMaster { get; set; }
    }
}
