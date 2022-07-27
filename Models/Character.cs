using System.Text.Json.Serialization;

namespace RelationshipsAPI.Models
{
    public class Character
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string RpgClass { get; set; } = "Cavaleiro";

        //Usuário no qual o personagem pertence
        [JsonIgnore]
        public User User { get; set; }

        public int UserId { get; set; }

        public Weapon Weapon { get; set; }

        public List<Skill> Skills { get; set; }
    }
}