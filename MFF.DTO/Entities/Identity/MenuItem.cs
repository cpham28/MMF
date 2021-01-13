using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MFF.DTO.Entities.Identity
{
    [Table("AspNetMenu")]
    public class MenuItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MenuItem()
        {
            Children = new HashSet<MenuItem>();
            RoleMenus = new HashSet<ApplicationRoleMenu>();
        }

        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        [StringLength(150)]
        public string Description { get; set; }

        public int? ParentId { get; set; }

        [StringLength(50)]
        public string Icon { get; set; }
        [StringLength(20)]
        public string Code { get; set; }

        [StringLength(150)]
        public string Url { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MenuItem> Children { get; set; }

        public virtual MenuItem ParentItem { get; set; }

        public virtual ICollection<ApplicationRoleMenu> RoleMenus { get; set; }

    }
}