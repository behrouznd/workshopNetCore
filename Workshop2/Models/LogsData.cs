using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop2.Models
{
    public class LogsData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LogId { get; set; }

        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string UserId { get; set; }
        public DateTime CreDate { get; set; }

    }
}
