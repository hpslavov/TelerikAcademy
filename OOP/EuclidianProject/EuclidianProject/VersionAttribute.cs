namespace EuclidianProject
{
    using System;
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]

    [VersionAttribute("2","11")]
    public class VersionAttribute : Attribute
    {
        public string Major { get; private set; }
        public string Minor { get; set; }

        public VersionAttribute(string major,string minor)
        {
            this.Major = major;
            this.Minor = minor;

        }

        public override string ToString()
        {
            return string.Format("Version: {0}.{1}",this.Major,this.Minor);
        }


    }
}
