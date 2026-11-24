namespace Workshop.Models;

public class WorkshopProject
{
    public int Id { get; set; }

    // Обов'язкові текстові властивості
    public string ProductName { get; set; } = "";        // Назва виробу
    public string MaterialsSummary { get; set; } = "";   // Перелік основних матеріалів

    // Необов'язковий опис (може бути null)
    public string? Notes { get; set; }                   // Примітки / деталі замовлення

    // Фінансові показники (decimal для точних розрахунків)
    public decimal MaterialCost { get; set; }            // Собівартість матеріалів
    public decimal SalePrice { get; set; }               // Ціна виробу (для зіставлення з собівартістю у ЛР 6)

    // Строки виготовлення (дати для зіставлення та групування за періодами у ЛР 9)
    public DateOnly StartedOn { get; set; }              // Дата початку роботи
    public DateOnly DeadlineOn { get; set; }             // Плановий строк здачі
    public DateOnly? CompletedOn { get; set; }           // Фактична дата завершення (null, якщо ще в роботі)

    // Етап виконання (enum)
    public ProjectStage Stage { get; set; } = ProjectStage.Draft;
}