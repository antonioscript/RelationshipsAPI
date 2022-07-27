namespace RelationshipsAPI.Models
{
    public class User
    {
        public int Id { get; set; }

        public string UserName { get; set; } = string.Empty;

        public int MyProperty { get; set; }

        //Lista de personagens que o usuário
        public List<Character> Characters { get; set; }

    }
}