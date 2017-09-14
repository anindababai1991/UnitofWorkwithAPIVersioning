namespace InnovationApp.DAL
{
    public partial class TemplateFeature
    {
        public int TemplateFeatureId { get; set; }

        public int TemplateId { get; set; }

        public int? FeatureOptionsId { get; set; }

        public virtual FeatureOption FeatureOption { get; set; }

        public virtual TemplateMaster TemplateMaster { get; set; }
    }
}
