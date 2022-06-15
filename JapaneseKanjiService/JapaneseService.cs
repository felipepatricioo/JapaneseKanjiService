using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JapaneseKanjiService
{
    public class JapaneseService
    {
        public string GetKanji()
        {
            Greeting greeting = _greetings.ElementAt(
                Random.Shared.Next(_greetings.Count));

            return $"{greeting.Katakana}: {greeting.Kanji}";
        }


        readonly HashSet<Greeting> _greetings = new()
        {
            new Greeting("つき", "月"),
            new Greeting("しんかんせん", "新幹線"),
            new Greeting("ちゅしゃじょう", "駐車場"),
            new Greeting("けいさつ", "警察"),
            new Greeting("びょういん", "病院"),
            new Greeting("にほん", "日本"),
            new Greeting("ばしょ", "場所"),
            new Greeting("とうきょう", "東京"),
            new Greeting("こころ", "心"),
            new Greeting("たべます", "食べます"),
            new Greeting("おもいます", "思います"),
            new Greeting("じしん", "地震"),
            new Greeting("どうぶつ", "動物"),
            new Greeting("だんけつ", "団結"),

        };

        public record Greeting(string Katakana, string Kanji);

    }
}
