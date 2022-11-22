using System;
using System.Collections.Generic;

namespace AtosEntityDatabaseFirst;

public partial class Pessoa
{
    public int Id { get; set; }

    public string nome { get; set; } = null!;

    public virtual ICollection<Email> Emails { get; set; } = new List<Email>();
}
