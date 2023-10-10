using System.ComponentModel.DataAnnotations;

namespace ToDoList.Domain.Enum;

public enum Priority
{
    [Display(Name = "Легко")]
    Easy = 1,
    [Display(Name = "Средне")]
    Medium = 2,
    [Display(Name = "Сложно")]
    Hard = 3
}