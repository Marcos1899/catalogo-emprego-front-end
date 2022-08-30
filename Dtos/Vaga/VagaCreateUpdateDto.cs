using System.ComponentModel.DataAnnotations;
using CatalogoEmpregoFront.Dtos.Empresa;

namespace CatalogoEmpregoFront.Dtos.Vaga;

public class VagaCreateUpdateDto
{    
    [Required(ErrorMessage ="Tipo de Vaga é obrigatório")]
    [StringLength(50, MinimumLength = 5,ErrorMessage ="Tipo de Vaga tem que ter entre 5 e 50 caracteres")]
    public string TipoVaga { get; set; }  

    [Required(ErrorMessage ="Número de Vagas é obrigatório")]
    public int NumeroVagas { get; set; }  

    [Required(ErrorMessage ="Salário é obrigatório")]
    [StringLength(50,ErrorMessage ="Máximo de 50 caracteres")]
    public String Salario { get; set; } 

    [Required(ErrorMessage ="Especificações é obrigatório")]
    [StringLength(255,ErrorMessage ="Máximo de 255 caracteres")]
    public String Especificacoes { get; set; }   

    public int Empresaid { get; set; } = 1;

    //Propriedade de navegação
    public EmpresaCreateUpdateDto Empresa { get; set; }  
}
