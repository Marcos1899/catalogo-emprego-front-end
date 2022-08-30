using System.ComponentModel.DataAnnotations;

namespace CatalogoEmpregoFront.Dtos.Empresa;

public class EmpresaCreateUpdateDto
{
   
   [Required(ErrorMessage ="Razão Social é obrigatório")]
   [StringLength(100, MinimumLength = 10,ErrorMessage ="Razão Social tem que ter entre 10 e 100 caracteres")]
   public  string RazaoSocial { get; set; }
   
   [Required(ErrorMessage ="Nome Fantasia é obrigatório")]
   [StringLength(100, MinimumLength = 10,ErrorMessage ="Nome Fantasia tem que ter entre 10 e 100 caracteres")]
   public  string NomeFantasia { get; set; }
   
   [Required(ErrorMessage ="Número do CNPJ é obrigatório")]
   [StringLength(14,ErrorMessage="Máximo de 14 caracteres")]
   public  string Cnpj { get; set; }
   
   [Required(ErrorMessage ="Cidade é obrigatório")]
   [MinLength(5,ErrorMessage="Minímo de 5 caracteres")]
   public  string Cidade { get; set; }
   
   [Required(ErrorMessage ="Estado é obrigatório")]
   [MinLength(4,ErrorMessage="Minímo de 4 caracteres")]
   public  string Estado { get; set; }
   
   [Required(ErrorMessage ="Endereço Completo é obrigatório é obrigatório")]
   [StringLength(100, MinimumLength =6,ErrorMessage ="Endereço Completo tem que ter entre 6 e 100 caracteres")]
   public  string Endereco { get; set; }
   
   [Required(ErrorMessage ="Número é obrigatório")]
   [MinLength(9,ErrorMessage="Minímo de 9 caracteres")]
   public  string Telefone { get; set; }
   
   [Required(ErrorMessage ="E-mail é obrigatório") ]
   [StringLength(100, MinimumLength =10,ErrorMessage ="E-mail tem que ter entre 6 e 100 caracteres")]
   public  string Email { get; set; }

   public int UsuarioId { get; set; } = 1;

   [Required(ErrorMessage ="Senha é obrigatório")]
   [MinLength(6,ErrorMessage="Minímo de 6 caracteres")]
   public string Senha { get; set; }

}
