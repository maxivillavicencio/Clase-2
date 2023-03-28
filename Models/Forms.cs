using System.ComponentModel.DataAnnotations;

public class Form{
    [Required]
    [Display(Name = "Correo Electronico")]
     public string Mail { get; set; }

    [Required]
    [Display(Name = "Contrasenia")]
    public string Passwd { get; set; }
}