namespace RelationshipsAPI.Dto
{
    public class CreateCharacterDto
    {
        public string Name { get; set; } = "Character";

        public string RpgClass { get; set; } = "Cavaleiro";

        public int UserId { get; set; } = 1;
    }
}