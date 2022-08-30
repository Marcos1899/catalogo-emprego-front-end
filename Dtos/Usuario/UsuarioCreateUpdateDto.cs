using System.ComponentModel.DataAnnotations;

namespace CatalogoEmpregoFront.Dtos.Usuario;

    public class UsuarioCreateUpdateDto
{
    [Required(ErrorMessage ="Nome Completo é obrigatório")]
    [StringLength(150, MinimumLength = 8,ErrorMessage ="Nome Completo tem que ter entre 10 e 100 caracteres")]
    public string NomeCompleto { get; set; }  

    [Required(ErrorMessage ="Endereço Completo é obrigatório")]
    [StringLength(255,ErrorMessage ="Máximo de 255 caracteres")]
    public string EnderecoCompleto { get; set; }  

    [Required(ErrorMessage ="Login é obrigatório")]
    [StringLength(15,ErrorMessage ="Máximo de 15 caracteres")]
    public string Login { get; set; }  

    [Required(ErrorMessage ="E-mail é obrigatório")]
    [StringLength(100,ErrorMessage ="Máximo de 100 caracteres")]
    [EmailAddress] //faz validação de email
    public string Email { get; set; }  

    [Required(ErrorMessage ="Senha é obrigatório")]
    [StringLength(10,ErrorMessage ="Máximo de 100 caracteres")]
    public string Senha { get; set; }  

    [Required(ErrorMessage ="CPF é obrigatório")]
    [StringLength(15,ErrorMessage ="Máximo de 100 caracteres")]
    public string Cpf { get; set; }  

    [Required(ErrorMessage ="Telefone é obrigatório")]
    [StringLength(25,ErrorMessage ="Máximo de 25 caracteres")]
    public string Telefone { get; set; }  

    [Required(ErrorMessage ="Cidade é obrigatório")]
    [StringLength(50,ErrorMessage ="Máximo de 50 caracteres")]
    public string Cidade { get; set; }  

    [Required(ErrorMessage ="Tipo de Usuário é obrigatório")]
    [StringLength(15,ErrorMessage ="Máximo de 15 caracteres")]
    public string TipoUsuario { get; set; } 

    [Required(ErrorMessage ="RG é obrigatório")]
    [StringLength(25,ErrorMessage ="Máximo de 25 caracteres")]
    public string Rg { get; set; }  

    //Propriedade de navegação
    public CurriculoCreateDto Curriculo { get; set; } = new();

}

public class CurriculoCreateDto
{ 
    [Required(ErrorMessage ="Formação é obrigatório")]
    [StringLength(100,MinimumLength = 8, ErrorMessage ="Minimo 8 Caracters,Máximo de 100 caracteres")]
    public string Formacao { get; set; }  

    [Required(ErrorMessage ="Cursos Complementares é obrigatório")]
    [StringLength(255,MinimumLength = 8,ErrorMessage ="Minimo 8 Caracters,Máximo de 255 caracteres")]
    public string CursosComplementares { get; set; }  

    [Required(ErrorMessage ="Experiência Profissional é obrigatório")]
    [StringLength(255,MinimumLength = 8,ErrorMessage ="Minimo 8 Caracters,Máximo de 255 caracteres")]
    public string ExperienciaProfissional { get; set; }  
}


