using System;
using System.Collections.Generic;

namespace AtosEntityDatabaseFirst;

public partial class Email
{
    public int Id { get; set; }

    public string email { get; set; } = null!;

    public int? FkPessoa { get; set; }

    public virtual Pessoa? FkPessoaNavigation { get; set; }
}
