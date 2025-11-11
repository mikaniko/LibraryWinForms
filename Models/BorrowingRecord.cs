namespace LibraryWinForms.Models
{
    public class BorrowingRecord
    {
        public Book Book { get; set; }
        public DateTime BorrowedOn { get; set; }
        public DateTime? ReturnedOn { get; set; }
    }
}