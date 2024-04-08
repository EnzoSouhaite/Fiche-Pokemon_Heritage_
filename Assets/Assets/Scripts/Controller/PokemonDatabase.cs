using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "NewPokemonDatabase", menuName = "Database/Pokemon", order = 0)]
public class PokemonDatabase : ScriptableObject
{
    public List<PokemonData> datas = new();

    public void InitData()
    {
        datas.RemoveAll(data => data.name == "");
    }

    public void CreateDataNoctali()
    {
        if (!datas.Exists(data => data.name == "Noctali"))
        {

            PokemonData.Stats stats = new()
            {
                pv = 95,
                attack = 65,
                defense = 110,
                atkSpe = 60,
                defSpe = 130,
                speed = 65,
            };
            string imagePath = $"Assets/Graphics/noctali.png";
            Sprite pokeIcon = (Sprite)AssetDatabase.LoadAssetAtPath(imagePath, typeof(Sprite));

            datas.Add(new PokemonData("Noctali", 0197, 1.0f, 27.0f, "Dark", pokeIcon, "Noctali (Umbreon en anglais et ブラッキー en japonais) est un Pokémon de la 2ème génération de type Tenebres. Il est majoritairement de couleur Noir. Il mesure 1.0 m (3.28 pieds) et pèse 27.0 kg (59.52 livres). Il fait partie de la catégorie des Pokémon Lune.", stats));
        }
    }
    public void CreateDataMentali()
    {
        if (!datas.Exists(data => data.name == "Mentali"))
        {

            PokemonData.Stats stats = new()
            {
                pv = 65,
                attack = 65,
                defense = 60,
                atkSpe = 130,
                defSpe = 95,
                speed = 110,
            };
            string imagePath = $"Assets/Graphics/mentali.png";
            Sprite pokeIcon = (Sprite)AssetDatabase.LoadAssetAtPath(imagePath, typeof(Sprite));

            datas.Add(new PokemonData("Mentali", 0196, 0.9f, 26.5f, "Psychic", pokeIcon, "Mentali (Espeon en anglais et エーフィ en japonais) est un Pokémon de la 2ème génération de type Psy. Il est majoritairement de couleur Violet. Il mesure 0.9 m (2.95 pieds) et pèse 26.5 kg (58.42 livres). Il fait partie de la catégorie des Pokémon Soleil.", stats));
        }
    }
    public void CreateDataPhyllali()
    {
        if (!datas.Exists(data => data.name == "Phyllali"))
        {

            PokemonData.Stats stats = new()
            {
                pv = 60,
                attack = 110,
                defense = 130,
                atkSpe = 60,
                defSpe = 65,
                speed = 95,
            };
            string imagePath = $"Assets/Graphics/phyllali.png";
            Sprite pokeIcon = (Sprite)AssetDatabase.LoadAssetAtPath(imagePath, typeof(Sprite));

            datas.Add(new PokemonData("Phyllali", 0470, 1.0f, 25.5f, "Grass", pokeIcon, "Phyllali (Leafeon en anglais et リーフィア en japonais) est un Pokémon de la 4ème génération de type Plante. Il est majoritairement de couleur Vert. Il mesure 1.0 m (3.28 pieds) et pèse 25.5 kg (56.22 livres). Il fait partie de la catégorie des Pokémon Verdoyant.", stats));
        }
    }
    public void CreateDataGivrali()
    {
        if (!datas.Exists(data => data.name == "Givrali"))
        {

            PokemonData.Stats stats = new()
            {
                pv = 65,
                attack = 60,
                defense = 110,
                atkSpe = 130,
                defSpe = 95,
                speed = 65,
            };
            string imagePath = $"Assets/Graphics/givrali.png";
            Sprite pokeIcon = (Sprite)AssetDatabase.LoadAssetAtPath(imagePath, typeof(Sprite));

            datas.Add(new PokemonData("Givrali", 0471, 0.8f, 25.9f, "Ice", pokeIcon, "Givrali (Glaceon en anglais et グレイシア en japonais) est un Pokémon de la 4ème génération de type Glace. Il est majoritairement de couleur Bleu. Il mesure 0.8 m (2.62 pieds) et pèse 25.9 kg (57.1 livres). Il fait partie de la catégorie des Pokémon Poudreuse.", stats));
        }
    }
    public void CreateDataNymphali()
    {
        if (!datas.Exists(data => data.name == "Nymphali"))
        {

            PokemonData.Stats stats = new()
            {
                pv = 95,
                attack = 65,
                defense = 65,
                atkSpe = 110,
                defSpe = 130,
                speed = 60,
            };
            string imagePath = $"Assets/Graphics/nymphali.png";
            Sprite pokeIcon = (Sprite)AssetDatabase.LoadAssetAtPath(imagePath, typeof(Sprite));

            datas.Add(new PokemonData("Nymphali", 0700, 1.0f, 23.5f, "Fairy", pokeIcon, "Nymphali (Sylveon en anglais et ニンフィア en japonais) est un Pokémon de la 6ème génération de type Fee. Il est majoritairement de couleur Rose. Il mesure 1.0 m (3.28 pieds) et pèse 23.5 kg (51.81 livres). Il fait partie de la catégorie des Pokémon Attachant.", stats));
        }
    }
    public void CreateDataAquali()
    {
        if (!datas.Exists(data => data.name == "Aquali"))
        {

            PokemonData.Stats stats = new()
            {
                pv = 130,
                attack = 65,
                defense = 60,
                atkSpe = 110,
                defSpe = 95,
                speed = 65,
            };
            string imagePath = $"Assets/Graphics/aquali.png";
            Sprite pokeIcon = (Sprite)AssetDatabase.LoadAssetAtPath(imagePath, typeof(Sprite));

            datas.Add(new PokemonData("Aquali", 0134, 1.0f, 29.0f, "Water", pokeIcon, "Aquali (Vaporeon en anglais et シャワーズ en japonais) est un Pokémon de la 1ère génération de type Eau. Il est majoritairement de couleur Bleu. Il mesure 1.0 m (3.28 pieds) et pèse 29.0 kg (63.93 livres). Il fait partie de la catégorie des Pokémon Bulleur.", stats));
        }
    }
    public void CreateDataVoltali()
    {
        if (!datas.Exists(data => data.name == "Voltali"))
        {

            PokemonData.Stats stats = new()
            {
                pv = 65,
                attack = 65,
                defense = 60,
                atkSpe = 110,
                defSpe = 95,
                speed = 130,
            };
            string imagePath = $"Assets/Graphics/voltali.png";
            Sprite pokeIcon = (Sprite)AssetDatabase.LoadAssetAtPath(imagePath, typeof(Sprite));

            datas.Add(new PokemonData("Voltali", 0134, 0.8f, 24.5f, "Electrick", pokeIcon, "Voltali (Jolteon en anglais et サンダース en japonais) est un Pokémon de la 1ère génération de type Electrik. Il est majoritairement de couleur Jaune. Il mesure 0.8 m (2.62 pieds) et pèse 24.5 kg (54.01 livres). Il fait partie de la catégorie des Pokémon Orage.", stats));
        }
    }

    public void CreateDataPyroli()
    {
        if (!datas.Exists(data => data.name == "Pyroli"))
        {

            PokemonData.Stats stats = new()
            {
                pv = 65,
                attack = 130,
                defense = 60,
                atkSpe = 95,
                defSpe = 110,
                speed = 65,
            };
            string imagePath = $"Assets/Graphics/pyroli.png";
            Sprite pokeIcon = (Sprite)AssetDatabase.LoadAssetAtPath(imagePath, typeof(Sprite));

            datas.Add(new PokemonData("Pyroli", 0136, 0.9f, 25.0f, "Fire", pokeIcon, "Pyroli (Flareon en anglais et ブースター en japonais) est un Pokémon de la 1ère génération de type Feu. Il est majoritairement de couleur Rouge. Il mesure 0.9 m (2.95 pieds) et pèse 25.0 kg (55.12 livres). Il fait partie de la catégorie des Pokémon Flamme.", stats));
        }
    }
    public void CreateDataEvoli()
    {
        if (!datas.Exists(data => data.name == "Évoli"))
        {

            PokemonData.Stats stats = new()
            {
                pv = 55,
                attack = 55,
                defense = 50,
                atkSpe = 45,
                defSpe = 65,
                speed = 55,
            };
            string imagePath = $"Assets/Graphics/evoli.png";
            Sprite pokeIcon = (Sprite)AssetDatabase.LoadAssetAtPath(imagePath, typeof(Sprite));

            datas.Add(new PokemonData("Évoli", 0133, 0.3f, 6.5f, "Normal", pokeIcon, "Évoli (Eevee en anglais et イーブイ en japonais) est un Pokémon de la 1ère génération de type Normal. Il est majoritairement de couleur Brun. Il mesure 0.3 m (0.98 pieds) et pèse 6.5 kg (14.33 livres). Il fait partie de la catégorie des Pokémon Évolutif.", stats));
        }
    }
    public void CreateDataPtera()
    {
        if (!datas.Exists(data => data.name == "Ptéra"))
        {

            PokemonData.Stats stats = new()
            {
                pv = 80,
                attack = 105,
                defense = 65,
                atkSpe = 60,
                defSpe = 75,
                speed = 130,
            };
            string imagePath = $"Assets/Graphics/ptera.png";
            Sprite pokeIcon = (Sprite)AssetDatabase.LoadAssetAtPath(imagePath, typeof(Sprite));

            datas.Add(new PokemonData("Ptéra", 0142, 1.8f, 59.0f, "Fly & Rock", pokeIcon, "Ptéra (Aerodactyl en anglais et プテラ en japonais) est un Pokémon de la 1ère génération de type Roche et Vol. Il est majoritairement de couleur Violet. Il mesure 1.8 m (5.9 pieds) et pèse 59.0 kg (130.07 livres). Il fait partie de la catégorie des Pokémon Fossile.", stats));
        }
    }
}