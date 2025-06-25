
        #region Vocab 

        private readonly string[][] KanaWords = new string[][] {
            // Hiragana
            // あ行 (A-row) - Contribution by Object777
            new string[] { "あれ", "あそこ", "あした", "あります", "あいさつ", "ありがとう" },
            new string[] { "いいえ", "いつ", "いぬ", "いる", "いちご", "いただきます" },
            new string[] { "うち", "うしろ", "うえ", "うどん", "うるさい", "うれしい" },
            new string[] { "ええ", "えき", "えび", "えいご", "えんぴつ", "えん" },
            new string[] { "おはよう", "おとな", "おいしい", "おわり", "おもしろい", "おもちゃ" },
            // か行 (Ka-row) - Contribution by Object777
            new string[] { "かさ", "かばん", "かお", "かわいい", "かける", "しかし" },
            new string[] { "きのう", "きれい", "きもの", "きみ", "きっぷ", "きらい" },
            new string[] { "ください", "くるま", "くつ", "くすり", "いくら", "くりかえす" },
            new string[] { "ける", "けが", "けんか", "けれど", "けっこん", "けじめ" },
            new string[] { "ことば", "こちら", "こども", "こめ", "こたつ", "こしょう" },
            // さ行 (Sa-row) - Contribution by Object777
            new string[] { "さよなら", "スミスさん", "さしみ", "さとう", "さびしい", "さわやか" },
            new string[] { "します", "しました", "しまう", "しお", "しっかり", "しかる" },
            new string[] { "する", "すし", "すみません", "すぐ", "すき", "すごい" },
            new string[] { "しません", "せんせい", "せんたく", "せまい", "せっかく", "あせる" },
            new string[] { "それ", "そこ", "そうです", "そば", "そうじ", "そろそろ" },
            // た行 (Ta-row) - Contribution by Nerazawa
            new string[] { "たべる", "たたみ", "たくさん", "ただ", "たまご", "たのしい" },
            new string[] { "ちち", "ちがう", "ちか", "ちいさい", "ちかい", "こっち" },
            new string[] { "つぎ", "つづく", "つけもの", "つよい", "つまらない", "つもり" },
            new string[] { "て", "てがみ", "てんき", "てんぷら", "てつだう", "てぶくろ" },
            new string[] { "とり", "ともだち", "とけい", "とても", "とうふ", "これとそれ" },
            // な行 (Na-row) - Contribution by Nerazawa
            new string[] { "ない", "なぜ", "なる", "なし", "なつかしい", "なくす" },
            new string[] { "にほん", "にわ", "にんじん", "にく", "にんげん", "ここにある" },
            new string[] { "ぬいぐるみ", "ぬるい", "ぬぐ", "ぬれる", "ぬる", "ぬすむ" },
            new string[] { "ねこ", "ねる", "ねむい", "ねだん", "ねぎ", "ねんきん" },
            new string[] { "のり", "のる", "のこり", "のせる", "のんびり", "[わたし]の[うち]" },
            // は行 (Ha-row) - Contribution by Nerazawa
            new string[] { "はい", "はし", "はなし", "ではまた。", "じつは", "わたしはスミスです。" },
            new string[] { "ひとつ", "ひと", "ひま", "ひだり", "ひどい", "ひっぱる" },
            new string[] { "ふたつ", "ふとん", "ふろ", "ふる", "ふれる", "ふく" },
            new string[] { "へや", "へた", "へる", "こちらへどうぞ", "どちらへ？", "みなさんへ" },
            new string[] { "ほんとう", "ほしい", "ほとんど", "ほうき", "ほこり", "ほうれんそう" },
            // ま行 (Ma-row - Contribution by Soup/Yuka ゆか
            new string[] { "まえ", "まだ", "まっすぐ", "まね", "まくら", "まじめ" },
            new string[] { "みどり", "みかん", "みなさん", "みぎ", "みみ", "みそしる" },
            new string[] { "むり", "むすめ", "（お）むすび", "むこう", "むずかしい", "むしあつい" },
            new string[] { "め", "めし", "めん", "めがね", "めんどう", "おめでとう" },
            new string[] { "もの", "もう", "もし", "もらう", "もっと", "もてる" },
            // や行 (Ya-row) - Contribution by Soup/Yuka ゆか
            new string[] { "やる", "やさしい", "やきとり", "やすみ", "やめる", "やかましい" },
            new string[] { "ゆ", "ゆき", "ゆめ", "ゆうびん", "ゆっくり", "ゆず" },
            new string[] { "よく", "よこ", "よむ", "よる", "よろしく", "よかった" },
            // ら行 (Ra-row) - Contribution by JustJaime
            new string[] { "あちら", "さくら", "いらっしゃいませ", "らしい", "らく", "らいねん" },
            new string[] { "りんご", "りっぱ", "いります", "りかい", "りこん", "りゆう" },
            new string[] { "るす", "るすばん", "るすちゅう", "まる", "るいじてん", "どうるい" },
            new string[] { "これ", "れい", "れんしゅう", "れきし", "れんらく", "れんこん" },
            new string[] { "ろく", "ろうか", "ろうじん", "くろ", "しろ", "むしろ" },
            // わ行 (Wa-row) - Contribution by JustJaime
            new string[] { "わたし", "わかる", "われる", "わけ", "わさび", "わがまま" },
            new string[] { "これをください。", "すしをたべた。", "そうじをした。", "めがねをかけた。", "あいさつをした。", "ここをかたづけよう。" },
            new string[] { "みんな", "うん", "こんにちは。", "おんな", "ぜんぜん", "まんが" },
            // 濁音 (Dakuon - Voiced sounds)
            // が行 (Ga-row)) - Contribution by Soup/Yuka ゆか
            new string[] { "これがいい。", "すみませんが", "がんばる", "がいじん", "がっかりする", "がまんする" },
            new string[] { "ぎんこう", "かぎ", "おにぎり", "ぎり", "ぎりぎり", "かぎる" },
            new string[] { "ぐあい", "ぐち", "ぐずぐず", "なぐる", "ぐうぜん", "ぐらい" },
            new string[] { "げんき", "げんかん", "げり", "げつまつ", "げんご", "げんいん" },
            new string[] { "ごはん", "ごみ", "ごちそうさま", "ございます", "ごま", "ごろ" },
            // ざ行 (Za-row) - Contribution by Soup/Yuka ゆか
            new string[] { "ざぶとん", "ざんねん", "ざっし", "ざる", "ざしき", "うざい" },
            new string[] { "じかん", "じぶん", "じこ", "じしん", "じてんしゃ", "じこちゅう" },
            new string[] { "ずるい", "ずいぶん", "ずっと", "ずれる", "ずらす", "ずぼん" },
            new string[] { "ぜんぶ", "かぜ", "まぜる", "ぜひ", "ぜったい", "ぜんたい" },
            new string[] { "どうぞ", "ぞう", "ごぞんじ です", "ぞうり", "ぞくする", "ぞくぞく" },
            // だ行 (Da-row) - Contribution by Soup/Yuka ゆか
            new string[] { "だめ", "だから", "だんだん", "だいじょうぶ", "だいがく", "だけ" },
            new string[] { "ちぢむ", "ちぢれる", "はなぢ", "てじか", "ちかじか", "わるきえ" },
            new string[] { "かたづける", "つづける", "つづく", "つづり", "かんづめ", "きづく" },
            new string[] { "でんわ", "できる", "でんき", "でかける", "です", "でたらめ" },
            new string[] { "どれ", "どうも", "どじ", "どこ", "どうして", "どろぼう" },
            // ば行 (Ba-row) - Contribution by Soup/Yuka ゆか
            new string[] { "ばか", "ばんざい", "ばら", "ばれる", "ばらばら", "ばかり" },
            new string[] { "びん", "びっくりする", "びっしょり", "びみょう", "びびる", "びんぼう" },
            new string[] { "あぶない", "ぶどう", "ぶた", "ぶっか", "ぶんか", "ぶしつけ" },
            new string[] { "べんきょう", "べんとう", "べつ", "べつべつ", "べんり", "べんごし" },
            new string[] { "ぼく", "ぼうし", "ぼろぼろ", "ぼっちゃん", "ぼう", "ぼうえき" },
            // ぱ行 (Pa-row) - Contribution by JustJaime
            new string[] { "ぱちぱち", "ぱらぱら", "ぱっと", "すっぱい", "さっぱり", "つっぱる" },
            new string[] { "ぴかぴか", "ちょっぴり", "ぴったり", "ぴりから", "へっぴりごし", "だだっぴろい" },
            new string[] { "じゅっぷん", "せんぷうき", "うっぷん", "まんぷく", "しらんぷり", "にんぷ" },
            new string[] { "ぺらぺら", "ぺこぺこ", "ぺちゃんこ", "ぺちゃくちゃ", "てっぺん", "いっぺん" },
            new string[] { "にっぽん", "さんぽ", "ぽんず", "しっぽ", "こどもっぽい", "いっぽうつうこう" },
            // 拗音 (Youon - Contracted sounds)
            // きゃ行 (Kya-row) - Contribution by Nerazawa
            new string[] { "きゃく", "おきゃくさん", "きゃくしつ", "しょうきゃく", "しっきゃく", "きゃっかんてき" },
            new string[] { "きゅう", "きゅうけい", "けんきゅう", "きゅうきゅうしゃ", "きゅうり", "きゅうしょく" },
            new string[] { "きょう", "きょねん", "きょうしつ", "せんきょ", "きょり", "きょうみ" },
            // しゃ行 (Sha-row) - Contribution by nerazawa
            new string[] { "しゃしん", "しゃべる", "しゃかい", "しゃいん", "しゃぶしゃぶ", "いしゃ" },
            new string[] { "しゅみ", "しゅくだい", "しゅじん", "しゅるい", "しゅう", "しゅっちょう" },
            new string[] { "しょうゆ", "しょうかい", "しょうがない", "でしょう", "しましょう", "しょうがっこう" },
            // ちゃ行 (Cha-row) - Contribution by Object777
            new string[] { "おちゃ", "ちゃん", "ちゃんと", "めちゃくちゃ", "ちゃわん", "ちゃぱつ" },
            new string[] { "ちゅうい", "ちゅうごく", "ちゅうがっこう", "ちゅうしょく", "はなしちゅう", "ちゅうかりょうり" },
            new string[] { "ちょっと", "ちょうど", "ちょくせつ", "ちょきん", "しゃちょう", "ちょう" },
            // にゃ行 (Nya-row) - Contribution by Object777
            new string[] { "にやんこ", "ぐにやぐにや", "こんにやく", "にやあにやあ", "ろうにゃくなんにょ", "ふにゃふにゃ" },
            new string[] { "にゅうりょく", "にゅうがく", "にゅうかい", "にゅういん", "きにゅうする", "ほにゅうるい" },
            new string[] { "にょう", "にょうけんさ", "にょうぼう", "にょうぼうもち", "にょきにょき", "にょろにょろ" },
            // ひゃ行 (Hya-row) - Contribution by Soup/Yuka ゆか
            new string[] { "ひゃく", "ひゃくさい", "ひゃくねん", "にひゃくえん", "ひゃっかてん", "ひゃっかじてん" },
            new string[] { "ひゅうひゅう" },
            new string[] { "ひょうか", "ひょうばん", "ひょう", "よていひょう", "ひょうきん", "ひょろひょろ" },
            // みゃ行 (Mya-row) - Contribution by Soup/Yuka ゆか
            new string[] { "まいく", "じんみゃく", "さんみゃく", "みゃくみゃく", "ぶんみゃく", "どうみゃく" },
            new string[] { "みゅうじん", "みゅうと", "みゅうじかる", "みゅうじあむ", "みゅうがく" },
            new string[] { "みょうにち", "みょうちょう", "みょうごにち", "みょうじ", "みょう", "じゅみょう" },
            // りゃ行 (Rya-row) - Contribution by Soup/Yuka ゆか
            new string[] { "りゃく", "りゃくご", "りゃくじ", "りゃくれき", "しょうりゃく", "ぜんりゃく" },
            new string[] { "りゅうがく", "りゅうがくせい", "りゅうこう", "しゅりゅう", "じこりゅう", "にほんりゅう" },
            new string[] { "りょこう", "りょうり", "りょうしん", "りょかん", "しりょう", "りょう" },
            // ぎゃ行 (Gya-row) - Contribution by Soup/Yuka ゆか
            new string[] { "ぎゃく", "ぎゃくたい", "ぎゃくせつ", "ぎゃくてん", "ぎゃっこう", "ぎゃっきょう" },
            new string[] { "ぎゅうにゅう", "ぎゅうにく", "ぎゅうぎゅう", "ぎゅっと", "ぎゅうどん", "ぎゅうじる" },
            new string[] { "ぎょうぎ", "ぎょうじ", "ぎょう", "ぎょうかい", "ぎょぎょう", "きんぎょ" },
            // じゃ行 (Ja-row) - Contribution by Soup/Yuka ゆか
            new string[] { "じゃあ", "じゃま", "じゃあまた", "じゃない", "じゃんけん", "じゃんじゃん" },
            new string[] { "じゅぎょう", "じゅうしょ", "じゅう", "じゅんばん", "じゅうよう", "きょうじゅ" },
            new string[] { "じょうず", "じょせい", "じょうだん", "じょしゅ", "じょゆう", "じょじょに" },
            // ぢゃ行 (Dja-row) - Contribution by Soup/Yuka ゆか
            new string[] { "ゆのみぢゃわん", "すもうぢゃや", "ぢゃぐち", "ぢゃま", "ぢゃり", "ぢゃんぷ" },
            new string[] { "*" },
            new string[] { "*" },
            // びゃ行 (Bya-row) - Contribution by Soup/Yuka ゆか
            new string[] { "さんびゃく", "なんびゃくえん" },
            new string[] { "びゅうびゅう" },
            new string[] { "びょうき", "びょういん" },
            // ぴゃ行 (Pya-row) - Contribution by Soup/Yuka ゆか
            new string[] { "ろっぴゃく", "はっぴゃく", "うそはっぴゃく" },
            new string[] { "ぴゅうぴゅう" },
            new string[] { "はっぴょう", "でんぴょう" },
            
            // Katakana
            // ア行 (A-row)
            new string[] { "ア", "ア", "ア", "ア", "ア", "ア" },
            new string[] { "イ", "イ", "イ", "イ", "イ", "イ" },
            new string[] { "ウ", "ウ", "ウ", "ウ", "ウ", "ウ" },
            new string[] { "エ", "エ", "エ", "エ", "エ", "エ" },
            new string[] { "オ", "オ", "オ", "オ", "オ", "オ" },
            // カ行 (Ka-row)
            new string[] { "カ", "カ", "カ", "カ", "カ", "カ" },
            new string[] { "キ", "キ", "キ", "キ", "キ", "キ" },
            new string[] { "ク", "ク", "ク", "ク", "ク", "ク" },
            new string[] { "ケ", "ケ", "ケ", "ケ", "ケ", "ケ" },
            new string[] { "コ", "コ", "コ", "コ", "コ", "コ" },
            // サ行 (Sa-row)
            new string[] { "サ", "サ", "サ", "サ", "サ", "サ" },
            new string[] { "シ", "シ", "シ", "シ", "シ", "シ" },
            new string[] { "ス", "ス", "ス", "ス", "ス", "ス" },
            new string[] { "セ", "セ", "セ", "セ", "セ", "セ" },
            new string[] { "ソ", "ソ", "ソ", "ソ", "ソ", "ソ" },
            // タ行 (Ta-row)
            new string[] { "タ", "タ", "タ", "タ", "タ", "タ" },
            new string[] { "チ", "チ", "チ", "チ", "チ", "チ" },
            new string[] { "ツ", "ツ", "ツ", "ツ", "ツ", "ツ" },
            new string[] { "テ", "テ", "テ", "テ", "テ", "テ" },
            new string[] { "ト", "ト", "ト", "ト", "ト", "ト" },
            // ナ行 (Na-row)
            new string[] { "ナ", "ナ", "ナ", "ナ", "ナ", "ナ" },
            new string[] { "ニ", "ニ", "ニ", "ニ", "ニ", "ニ" },
            new string[] { "ヌ", "ヌ", "ヌ", "ヌ", "ヌ", "ヌ" },
            new string[] { "ネ", "ネ", "ネ", "ネ", "ネ", "ネ" },
            new string[] { "ノ", "ノ", "ノ", "ノ", "ノ", "ノ" },
            // ハ行 (Ha-row)
            new string[] { "ハ", "ハ", "ハ", "ハ", "ハ", "ハ" },
            new string[] { "ヒ", "ヒ", "ヒ", "ヒ", "ヒ", "ヒ" },
            new string[] { "フ", "フ", "フ", "フ", "フ", "フ" },
            new string[] { "ヘ", "ヘ", "ヘ", "ヘ", "ヘ", "ヘ" },
            new string[] { "ホ", "ホ", "ホ", "ホ", "ホ", "ホ" },
            // マ行 (Ma-row)
            new string[] { "マ", "マ", "マ", "マ", "マ", "マ" },
            new string[] { "ミ", "ミ", "ミ", "ミ", "ミ", "ミ" },
            new string[] { "ム", "ム", "ム", "ム", "ム", "ム" },
            new string[] { "メ", "メ", "メ", "メ", "メ", "メ" },
            new string[] { "モ", "モ", "モ", "モ", "モ", "モ" },
            // ヤ行 (Ya-row)
            new string[] { "ヤ", "ヤ", "ヤ", "ヤ", "ヤ", "ヤ" },
            new string[] { "ユ", "ユ", "ユ", "ユ", "ユ", "ユ" },
            new string[] { "ヨ", "ヨ", "ヨ", "ヨ", "ヨ", "ヨ" },
            // ラ行 (Ra-row)
            new string[] { "ラ", "ラ", "ラ", "ラ", "ラ", "ラ" },
            new string[] { "リ", "リ", "リ", "リ", "リ", "リ" },
            new string[] { "ル", "ル", "ル", "ル", "ル", "ル" },
            new string[] { "レ", "レ", "レ", "レ", "レ", "レ" },
            new string[] { "ロ", "ロ", "ロ", "ロ", "ロ", "ロ" },
            // ワ行 (Wa-row)
            new string[] { "ワ", "ワ", "ワ", "ワ", "ワ", "ワ" },
            new string[] { "ヲ", "ヲ", "ヲ", "ヲ", "ヲ", "ヲ" },
            new string[] { "ン", "ン", "ン", "ン", "ン", "ン" },
            // 濁音 (Dakuon - Voiced sounds)
            // ガ行 (Ga-row)
            new string[] { "ガ", "ガ", "ガ", "ガ", "ガ", "ガ" },
            new string[] { "ギ", "ギ", "ギ", "ギ", "ギ", "ギ" },
            new string[] { "グ", "グ", "グ", "グ", "グ", "グ" },
            new string[] { "ゲ", "ゲ", "ゲ", "ゲ", "ゲ", "ゲ" },
            new string[] { "ゴ", "ゴ", "ゴ", "ゴ", "ゴ", "ゴ" },
            // ザ行 (Za-row)
            new string[] { "ザ", "ザ", "ザ", "ザ", "ザ", "ザ" },
            new string[] { "ジ", "ジ", "ジ", "ジ", "ジ", "ジ" },
            new string[] { "ズ", "ズ", "ズ", "ズ", "ズ", "ズ" },
            new string[] { "ゼ", "ゼ", "ゼ", "ゼ", "ゼ", "ゼ" },
            new string[] { "ゾ", "ゾ", "ゾ", "ゾ", "ゾ", "ゾ" },
            // ダ行 (Da-row)
            new string[] { "ダ", "ダ", "ダ", "ダ", "ダ", "ダ" },
            new string[] { "ヂ", "ヂ", "ヂ", "ヂ", "ヂ", "ヂ" },
            new string[] { "ヅ", "ヅ", "ヅ", "ヅ", "ヅ", "ヅ" },
            new string[] { "デ", "デ", "デ", "デ", "デ", "デ" },
            new string[] { "ド", "ド", "ド", "ド", "ド", "ド" },
            // バ行 (Ba-row)
            new string[] { "バ", "バ", "バ", "バ", "バ", "バ" },
            new string[] { "ビ", "ビ", "ビ", "ビ", "ビ", "ビ" },
            new string[] { "ブ", "ブ", "ブ", "ブ", "ブ", "ブ" },
            new string[] { "ベ", "ベ", "ベ", "ベ", "ベ", "ベ" },
            new string[] { "ボ", "ボ", "ボ", "ボ", "ボ", "ボ" },
            // パ行 (Pa-row)
            new string[] { "パ", "パ", "パ", "パ", "パ", "パ" },
            new string[] { "ピ", "ピ", "ピ", "ピ", "ピ", "ピ" },
            new string[] { "プ", "プ", "プ", "プ", "プ", "プ" },
            new string[] { "ペ", "ペ", "ペ", "ペ", "ペ", "ペ" },
            new string[] { "ポ", "ポ", "ポ", "ポ", "ポ", "ポ" },
            // 拗音 (Youon - Contracted sounds)
            // キャ行 (Kya-row)
            new string[] { "キャ", "キャ", "キャ", "キャ", "キャ", "キャ" },
            new string[] { "キュ", "キュ", "キュ", "キュ", "キュ", "キュ" },
            new string[] { "キョ", "キョ", "キョ", "キョ", "キョ", "キョ" },
            // シャ行 (Sha-row)
            new string[] { "シャ", "シャ", "シャ", "シャ", "シャ", "シャ" },
            new string[] { "シュ", "シュ", "シュ", "シュ", "シュ", "シュ" },
            new string[] { "シェ", "シェ", "シェ", "シェ", "シェ", "シェ" },
            new string[] { "ショ", "ショ", "ショ", "ショ", "ショ", "ショ" },
            // チャ行 (Cha-row)
            new string[] { "チャ", "チャ", "チャ", "チャ", "チャ", "チャ" },
            new string[] { "チュ", "チュ", "チュ", "チュ", "チュ", "チュ" },
            new string[] { "チェ", "チェ", "チェ", "チェ", "チェ", "チェ" },
            new string[] { "チョ", "チョ", "チョ", "チョ", "チョ", "チョ" },
            // ニャ行 (Nya-row)
            new string[] { "ニャ", "ニャ", "ニャ", "ニャ", "ニャ", "ニャ" },
            new string[] { "ニュ", "ニュ", "ニュ", "ニュ", "ニュ", "ニュ" },
            new string[] { "ニョ", "ニョ", "ニョ", "ニョ", "ニョ", "ニョ" },
            // ヒャ行 (Hya-row)
            new string[] { "ヒャ", "ヒャ", "ヒャ", "ヒャ", "ヒャ", "ヒャ" },
            new string[] { "ヒュ", "ヒュ", "ヒュ", "ヒュ", "ヒュ", "ヒュ" },
            new string[] { "ヒョ", "ヒョ", "ヒョ", "ヒョ", "ヒョ", "ヒョ" },
            // ミャ行 (Mya-row)
            new string[] { "ミャ", "ミャ", "ミャ", "ミャ", "ミャ", "ミャ" },
            new string[] { "ミュ", "ミュ", "ミュ", "ミュ", "ミュ", "ミュ" },
            new string[] { "ミョ", "ミョ", "ミョ", "ミョ", "ミョ", "ミョ" },
            // リャ行 (Rya-row)
            new string[] { "リャ", "リャ", "リャ", "リャ", "リャ", "リャ" },
            new string[] { "リュ", "リュ", "リュ", "リュ", "リュ", "リュ" },
            new string[] { "リョ", "リョ", "リョ", "リョ", "リョ", "リョ" },
            // ギャ行 (Gya-row)
            new string[] { "ギャ", "ギャ", "ギャ", "ギャ", "ギャ", "ギャ" },
            new string[] { "ギュ", "ギュ", "ギュ", "ギュ", "ギュ", "ギュ" },
            new string[] { "ギョ", "ギョ", "ギョ", "ギョ", "ギョ", "ギョ" },
            // ジャ行 (Ja-row)
            new string[] { "ジャ", "ジャ", "ジャ", "ジャ", "ジャ", "ジャ" },
            new string[] { "ジュ", "ジュ", "ジュ", "ジュ", "ジュ", "ジュ" },
            new string[] { "ジェ", "ジェ", "ジェ", "ジェ", "ジェ", "ジェ" },
            new string[] { "ジョ", "ジョ", "ジョ", "ジョ", "ジョ", "ジョ" },
            // ビャ行 (Bya-row)
            new string[] { "ビャ", "ビャ", "ビャ", "ビャ", "ビャ", "ビャ" },
            new string[] { "ビュ", "ビュ", "ビュ", "ビュ", "ビュ", "ビュ" },
            new string[] { "ビョ", "ビョ", "ビョ", "ビョ", "ビョ", "ビョ" },
            // ピャ行 (Pya-row)
            new string[] { "ピャ", "ピャ", "ピャ", "ピャ", "ピャ", "ピャ" },
            new string[] { "ピュ", "ピュ", "ピュ", "ピュ", "ピュ", "ピュ" },
            new string[] { "ピョ", "ピョ", "ピョ", "ピョ", "ピョ", "ピョ" },
            // 外来音 (Gairaigo - Loan/foreign sounds)
            // ティ・トゥ行 (Ti/Tu-row)
            new string[] { "ティ", "ティ", "ティ", "ティ", "ティ", "ティ" },
            new string[] { "トゥ", "トゥ", "トゥ", "トゥ", "トゥ", "トゥ" },
            // ディ・ドゥ行 (Di/Du-row)
            new string[] { "ディ", "ディ", "ディ", "ディ", "ディ", "ディ" },
            new string[] { "ドゥ", "ドゥ", "ドゥ", "ドゥ", "ドゥ", "ドゥ" },
            // ファ行 (Fa-row)
            new string[] { "ファ", "ファ", "ファ", "ファ", "ファ", "ファ" },
            new string[] { "フ", "フ", "フ", "フ", "フ", "フ" },
            new string[] { "フュ", "フュ", "フュ", "フュ", "フュ", "フュ" },
            new string[] { "フェ", "フェ", "フェ", "フェ", "フェ", "フェ" },
            new string[] { "フォ", "フォ", "フォ", "フォ", "フォ", "フォ" },
            // ツァ行 (Tsa-row)
            new string[] { "ツァ", "ツァ", "ツァ", "ツァ", "ツァ", "ツァ" },
            new string[] { "ツィ", "ツィ", "ツィ", "ツィ", "ツィ", "ツィ" },
            new string[] { "ツェ", "ツェ", "ツェ", "ツェ", "ツェ", "ツェ" },
            // ウィ行 (Wi-row)
            new string[] { "ウィ", "ウィ", "ウィ", "ウィ", "ウィ", "ウィ" },
            new string[] { "ウェ", "ウェ", "ウェ", "ウェ", "ウェ", "ウェ" },
            new string[] { "ウォ", "ウォ", "ウォ", "ウォ", "ウォ", "ウォ" },
            // ヴァ行 (Va-row)
            new string[] { "ヴァ", "ヴァ", "ヴァ", "ヴァ", "ヴァ", "ヴァ" },
            new string[] { "ヴィ", "ヴィ", "ヴィ", "ヴィ", "ヴィ", "ヴィ" },
            new string[] { "ヴ", "ヴ", "ヴ", "ヴ", "ヴ", "ヴ" },
            new string[] { "ヴェ", "ヴェ", "ヴェ", "ヴェ", "ヴェ", "ヴェ" },
            new string[] { "ヴォ", "ヴォ", "ヴォ", "ヴォ", "ヴォ", "ヴォ" }
        };

        private readonly string[][] KanaWordsRomaji = new string[][] {
            // Hiragana
            // あ行 (A-row) - Contribution by Object777
            new string[] { "are", "asoko", "ashita", "arimasu", "aisatsu", "arigatō" },
            new string[] { "iie", "itsu", "inu", "iru", "ichigo", "itadakimasu" },
            new string[] { "uchi", "ushiro", "ue", "udon", "urusai", "ureshii" },
            new string[] { "ee", "eki", "ebi", "eigo", "enpitsu", "en" },
            new string[] { "ohayō", "otona", "oishii", "owari", "omoshiroi", "omocha" },
            // か行 (Ka-row) - Contribution by Object777
            new string[] { "kasa", "kaban", "kao", "kawaii", "kakeru", "shikashi" },
            new string[] { "kinō", "kirei", "kimono", "kimi", "kippu", "kirai" },
            new string[] { "kudasai", "kuruma", "kutsu", "kusuri", "ikura", "kurikaesu" },
            new string[] { "keru", "kega", "kenka", "keredo", "kekkon", "kejime" },
            new string[] { "kotoba", "kochira", "kodomo", "kome", "kotatsu", "koshō" },
            // さ行 (Sa-row) - Contribution by Object777
            new string[] { "sayonara", "sumisu san", "sashimi", "satō", "sabishii", "sawayaka" },
            new string[] { "shimasu", "shimashita", "shimau", "shio", "shikkari", "shikaru" },
            new string[] { "suru", "sushi", "sumimasen", "sugu", "suki", "sugoi" },
            new string[] { "shimasen", "sensei", "sentaku", "semai", "sekkaku", "aseru" },
            new string[] { "sore", "soko", "sōdesu", "soba", "sōji", "sorosoro" },
            // た行 (Ta-row) - Contribution by Nerazawa
            new string[] { "taberu", "tatami", "takusan", "tada", "tamago", "tanoshii" },
            new string[] { "chichi", "chigau", "chika", "chiisai", "chikai", "kocchi" },
            new string[] { "tsugi", "tsuzuku", "tsukemono", "tsuyoi", "tsumaranai", "tsumori" },
            new string[] { "te", "tegami", "tenki", "tenpura", "tetsudau", "tebukuro" },
            new string[] { "tori", "tomodachi", "tokei", "totemo", "tōfu", "koretosore" },
            // な行 (Na-row) - Contribution by Nerazawa
            new string[] { "nai", "naze", "naru", "nashi", "natsukashii", "nakusu" },
            new string[] { "nihon", "niwa", "ninjin", "niku", "ningen", "koko ni aru" },
            new string[] { "nuigurumi", "nurui", "nugu", "nureru", "nuru", "nusumu" },
            new string[] { "neko", "neru", "nemui", "nedan", "negi", "nenkin" },
            new string[] { "nori", "noru", "nokori", "noseru", "nonbiri", "watashi no uchi" },
            // は行 (Ha-row) - Contribution by Nerazawa
            new string[] { "hai", "hashi", "hanashi", "Dewa mata.", "jitsu wa", "Watashi wa Sumisu desu." },
            new string[] { "hitotsu", "hito", "hima", "hidari", "hidoi", "hipparu" },
            new string[] { "futatsu", "futon", "furo", "furu", "fureru", "fuku" },
            new string[] { "heya", "heta", "heru", "Kochira e dōzo.", "Dochira e?", "minasan e" },
            new string[] { "hontō", "hoshii", "hotondo", "hōki", "hokori", "hōrensō" },
            // ま行 (Ma-row) - Contribution by Soup
            new string[] { "mae", "mada", "massugu", "mane", "makura", "majime" },
            new string[] { "midori", "mikan", "minasan", "migi", "mimi", "misoshiru" },
            new string[] { "muri", "musume", "(o)musubi", "mukō", "muzukashii", "mushiatsui" },
            new string[] { "me", "meshi", "men", "megane", "mendō", "omedetō" },
            new string[] { "mono", "mō", "moshi", "morau", "motto", "moteru" },
            // や行 (Ya-row) - Contribution by Soup
            new string[] { "yaru", "yasashii", "yakitori", "yasumi", "yameru", "yakamashii" },
            new string[] { "yu", "yuki", "yume", "yūbin", "yukkuri", "yuzu" },
            new string[] { "yoku", "yoko", "yomu", "yoru", "yoroshiku", "yokatta" },
            // ら行 (Ra-row) - Contribution by JustJaime
            new string[] { "achira", "sakura", "irasshaimase", "rashii", "raku", "rainen" },
            new string[] { "ringo", "rippa", "irimasu", "rikai", "rikon", "riyū" },
            new string[] { "rusu", "rusuban", "rusuchū", "maru", "ruijiten", "dōrui" },
            new string[] { "kore", "rei", "renshū", "rekishi", "renraku", "renkon" },
            new string[] { "roku", "rōka", "rōjin", "kuro", "shiro", "mushiro" },
            // わ行 (Wa-row) - Contribution by JustJaime
            new string[] { "watashi", "wakaru", "wareru", "wake", "wasabi", "wagamama" },
            new string[] { "Kore o kudasai.", "Sushi o tabeta.", "Sōji o shita", "Megane o kaketa.", "Aisatsu o shita.", "Koko o katazukeyō." },
            new string[] { "minna", "un", "Konnichiwa.", "onna", "zenzen", "manga" },
            // 濁音 (Dakuon - Voiced sounds)
            // が行 (Ga-row) - Contribution by Soup
            new string[] { "kore ga ii.", "sumimasen ga", "ganbaru", "gaijin", "gakkari suru", "gaman suru" },
            new string[] { "ginkō", "kagi", "onigiri", "giri", "girigiri", "kagiru" },
            new string[] { "guai", "guchi", "guzuguzu", "naguru", "gūzen", "gurai" },
            new string[] { "genki", "genkan", "geri", "getsumatsu", "gengo", "genin" },
            new string[] { "gohan", "gomi", "gochisōsama", "gozaimasu", "goma", "goro" },
            // ざ行 (Za-row) - Contribution by Soup
            new string[] { "zabuton", "zannen", "zasshi", "zaru", "zashiki", "uzai" },
            new string[] { "jikan", "jibun", "jiko", "jishin", "jitensha", "jikochū" },
            new string[] { "zurui", "zuibun", "zutto", "zureru", "zurasu", "zubon" },
            new string[] { "zenbu", "kaze", "mazeru", "zehi", "zettai", "zentai" },
            new string[] { "dōzo", "zō", "gozonji desu", "zōri", "zokusuru", "zokuzoku" },
            // だ行 (Da-row) - Contribution by Soup
            new string[] { "dame", "dakara", "dandan", "daijōbu", "daigaku", "dake" },
            new string[] { "chijimu", "chijireru", "hanaji", "tejika", "chikajika", "warukie" },
            new string[] { "katazukeru", "tsuzukeru", "tsuzuku", "tsuzuri", "kanzume", "kizuku" },
            new string[] { "denwa", "dekiru", "denki", "dekakeru", "desu", "detarame" },
            new string[] { "dore", "dōmo", "doji", "doko", "dōshite", "dorobō" },
            // ば行 (Ba-row) - Contribution by Soup
            new string[] { "baka", "banzai", "bara", "bareru", "barabara", "bakari" },
            new string[] { "bin", "bikkurisuru", "bisshori", "bimyō", "bibiru", "binbō" },
            new string[] { "abunai", "budō", "buta", "bukka", "bunka", "bushitsuke" },
            new string[] { "benkyō", "bentō", "betsu", "betsubetsu", "benri", "bengoshi" },
            new string[] { "boku", "bōshi", "boroboro", "bocchan", "bō", "bōeki" },
            // ぱ行 (Pa-row) - Contribution by JustJaime
            new string[] { "pachipachi", "parapara", "patto", "suppai", "sappari", "tsupparu" },
            new string[] { "pikapika", "choppiri", "pittari", "pirikara", "heppirigoshi", "dadappiroi" },
            new string[] { "juppun", "senpūki", "uppun", "manpuku", "shiranpuri", "ninpu" },
            new string[] { "perapera", "pekopeko", "pechanko", "pechakucha", "teppen", "ippen" },
            new string[] { "Nippon", "sanpo", "ponzu", "shippo", "kodomoppoi", "ippōtsūkō" },
            // 拗音 (Youon - Contracted sounds)
            // きゃ行 (Kya-row) - Contribution by Nerazawa
            new string[] { "kyaku", "okyaku san", "kyakushitsu", "shōkyaku", "shikkyaku", "kyakkanteki" },
            new string[] { "kyū", "kyūkei", "kenkyū", "kyūkyūsha", "kyūri", "kyūshoku" },
            new string[] { "kyō", "kyonen", "kyōshitsu", "senkyo", "kyori", "kyōmi" },
            // しゃ行 (Sha-row) - Contribution by nerazawa
            new string[] { "shashin", "shaberu", "shakai", "shain", "shabushabu", "isha" },
            new string[] { "shumi", "shukudai", "shujin", "shurui", "shū", "shucchō" },
            new string[] { "shōyu", "shōkai", "shō ga nai", "deshō", "shimashō", "shōgakkō" },
            // ちゃ行 (Cha-row) - Contribution by Object777
            new string[] { "ocha", "[name]-chan", "chanto", "mechakucha", "chawan", "chapatsu" },
            new string[] { "chūi", "chūgoku", "chūgakkō", "chūshoku", "hanashichū", "chūkaryōri" },
            new string[] { "chotto", "chōdo", "chokusetsu", "chokin", "shachō", "chō" },
            // にゃ行 (Nya-row) - Contribution by Object777
            new string[] { "nyanko", "gunyagunya", "konnyaku", "nyānyā", "rōnyakunannyo", "funyafunya" },
            new string[] { "nyūryoku", "nyūgaku", "nyūkai", "nyūin", "kinyū suru", "honyūrui" },
            new string[] { "nyō", "nyōkensa", "nyōbō", "nyōbōmochi", "nyokinyoki", "nyoronyoro" },
            // ひゃ行 (Hya-row) - Contribution by Soup
            new string[] { "hyaku", "hyakusai", "hyakunen", "nihyakuen", "hyakkaten", "hyakkajiten" },
            new string[] { "hyūhyū" },
            new string[] { "hyōka", "hyōban", "hyō", "yoteihyō", "hyōkin", "hyorohyoro" },
            // みゃ行 (Mya-row) - Contribution by Soup/Yuka ゆか
            new string[] { "mayku", "jinmyaku", "sanmyaku", "myakumyaku", "bunmyaku", "dōmyaku" },
            new string[] { "myūjin", "myūgaku" },
            new string[] { "myōnichi", "myōchō", "myōgonichi", "myōji", "myō", "jumyō" },
            // りゃ行 (Rya-row) - Contribution by Soup/Yuka ゆか
            new string[] { "ryaku", "ryakugo", "ryakuji", "ryakureki", "shōryaku", "zenryaku" },
            new string[] { "ryūgaku", "ryūgakusei", "ryūko", "shuryū", "jikoryū", "nihonryū" },
            new string[] { "ryokō", "ryōri", "ryōshin", "ryokan", "shiryō", "ryō" },
            // ぎゃ行 (Gya-row) - Contribution by Soup/Yuka ゆか
            new string[] { "gyaku", "gyakutai", "gyakusetsu", "gyakuten", "gyakkō", "gyakkyō" },
            new string[] { "gyūnyū", "gyūniku", "gyūgyū", "gyutto", "gyūdon", "gyūjiru" },
            new string[] { "gyōgi", "gyōji", "gyō", "gyōkai", "gyogyō", "kingyo" },
            // じゃ行 (Ja-row) - Contribution by Soup/Yuka ゆか
            new string[] { "jā", "jama", "jā mata", "ja nai", "janken", "janjan" },
            new string[] { "jugyō", "jyūsho", "jū", "junban", "jūyō", "kyōju" },
            new string[] { "jōzu", "josei", "jōdan", "joshu", "joyū", "jojo ni" },
            // ぢゃ行 (Dja-row) - Contribution by Soup/Yuka ゆか
            new string[] { "yunomi-jawan", "sumō-jaya", "jaguchi", "jama", "jari", "janpu" },
            new string[] { "*" },
            new string[] { "*" },
            // びゃ行 (Bya-row) - Contribution by Soup/Yuka ゆか
            new string[] { "sanbyaku", "nan byaku en" },
            new string[] { "byūbyū" },
            new string[] { "byōki", "byōin" },
            // ぴゃ行 (Pya-row) - Contribution by Soup/Yuka ゆか
            new string[] { "roppyaku", "happyaku", "uso-happyaku" },
            new string[] { "pyūpyū" },
            new string[] { "happyō", "denpyō" },
            
            // Katakana
            // ア行 (A-row)
            new string[] { "a", "a", "a", "a", "a", "a" },
            new string[] { "i", "i", "i", "i", "i", "i" },
            new string[] { "u", "u", "u", "u", "u", "u" },
            new string[] { "e", "e", "e", "e", "e", "e" },
            new string[] { "o", "o", "o", "o", "o", "o" },
            // カ行 (Ka-row)
            new string[] { "ka", "ka", "ka", "ka", "ka", "ka" },
            new string[] { "ki", "ki", "ki", "ki", "ki", "ki" },
            new string[] { "ku", "ku", "ku", "ku", "ku", "ku" },
            new string[] { "ke", "ke", "ke", "ke", "ke", "ke" },
            new string[] { "ko", "ko", "ko", "ko", "ko", "ko" },
            // サ行 (Sa-row)
            new string[] { "sa", "sa", "sa", "sa", "sa", "sa" },
            new string[] { "shi", "shi", "shi", "shi", "shi", "shi" },
            new string[] { "su", "su", "su", "su", "su", "su" },
            new string[] { "se", "se", "se", "se", "se", "se" },
            new string[] { "so", "so", "so", "so", "so", "so" },
            // タ行 (Ta-row)
            new string[] { "ta", "ta", "ta", "ta", "ta", "ta" },
            new string[] { "chi", "chi", "chi", "chi", "chi", "chi" },
            new string[] { "tsu", "tsu", "tsu", "tsu", "tsu", "tsu" },
            new string[] { "te", "te", "te", "te", "te", "te" },
            new string[] { "to", "to", "to", "to", "to", "to" },
            // ナ行 (Na-row)
            new string[] { "na", "na", "na", "na", "na", "na" },
            new string[] { "ni", "ni", "ni", "ni", "ni", "ni" },
            new string[] { "nu", "nu", "nu", "nu", "nu", "nu" },
            new string[] { "ne", "ne", "ne", "ne", "ne", "ne" },
            new string[] { "no", "no", "no", "no", "no", "no" },
            // ハ行 (Ha-row)
            new string[] { "ha", "ha", "ha", "ha", "ha", "ha" },
            new string[] { "hi", "hi", "hi", "hi", "hi", "hi" },
            new string[] { "fu", "fu", "fu", "fu", "fu", "fu" },
            new string[] { "he", "he", "he", "he", "he", "he" },
            new string[] { "ho", "ho", "ho", "ho", "ho", "ho" },
            // マ行 (Ma-row)
            new string[] { "ma", "ma", "ma", "ma", "ma", "ma" },
            new string[] { "mi", "mi", "mi", "mi", "mi", "mi" },
            new string[] { "mu", "mu", "mu", "mu", "mu", "mu" },
            new string[] { "me", "me", "me", "me", "me", "me" },
            new string[] { "mo", "mo", "mo", "mo", "mo", "mo" },
            // ヤ行 (Ya-row)
            new string[] { "ya", "ya", "ya", "ya", "ya", "ya" },
            new string[] { "yu", "yu", "yu", "yu", "yu", "yu" },
            new string[] { "yo", "yo", "yo", "yo", "yo", "yo" },
            // ラ行 (Ra-row)
            new string[] { "ra", "ra", "ra", "ra", "ra", "ra" },
            new string[] { "ri", "ri", "ri", "ri", "ri", "ri" },
            new string[] { "ru", "ru", "ru", "ru", "ru", "ru" },
            new string[] { "re", "re", "re", "re", "re", "re" },
            new string[] { "ro", "ro", "ro", "ro", "ro", "ro" },
            // ワ行 (Wa-row)
            new string[] { "wa", "wa", "wa", "wa", "wa", "wa" },
            new string[] { "wo", "wo", "wo", "wo", "wo", "wo" },
            new string[] { "n", "n", "n", "n", "n", "n" },
            // 濁音 (Dakuon - Voiced sounds)
            // ガ行 (Ga-row)
            new string[] { "ga", "ga", "ga", "ga", "ga", "ga" },
            new string[] { "gi", "gi", "gi", "gi", "gi", "gi" },
            new string[] { "gu", "gu", "gu", "gu", "gu", "gu" },
            new string[] { "ge", "ge", "ge", "ge", "ge", "ge" },
            new string[] { "go", "go", "go", "go", "go", "go" },
            // ザ行 (Za-row)
            new string[] { "za", "za", "za", "za", "za", "za" },
            new string[] { "ji", "ji", "ji", "ji", "ji", "ji" },
            new string[] { "zu", "zu", "zu", "zu", "zu", "zu" },
            new string[] { "ze", "ze", "ze", "ze", "ze", "ze" },
            new string[] { "zo", "zo", "zo", "zo", "zo", "zo" },
            // ダ行 (Da-row)
            new string[] { "da", "da", "da", "da", "da", "da" },
            new string[] { "ji", "ji", "ji", "ji", "ji", "ji" },
            new string[] { "zu", "zu", "zu", "zu", "zu", "zu" },
            new string[] { "de", "de", "de", "de", "de", "de" },
            new string[] { "do", "do", "do", "do", "do", "do" },
            // バ行 (Ba-row)
            new string[] { "ba", "ba", "ba", "ba", "ba", "ba" },
            new string[] { "bi", "bi", "bi", "bi", "bi", "bi" },
            new string[] { "bu", "bu", "bu", "bu", "bu", "bu" },
            new string[] { "be", "be", "be", "be", "be", "be" },
            new string[] { "bo", "bo", "bo", "bo", "bo", "bo" },
            // パ行 (Pa-row)
            new string[] { "pa", "pa", "pa", "pa", "pa", "pa" },
            new string[] { "pi", "pi", "pi", "pi", "pi", "pi" },
            new string[] { "pu", "pu", "pu", "pu", "pu", "pu" },
            new string[] { "pe", "pe", "pe", "pe", "pe", "pe" },
            new string[] { "po", "po", "po", "po", "po", "po" },
            // 拗音 (Youon - Contracted sounds)
            // キャ行 (Kya-row)
            new string[] { "kya", "kya", "kya", "kya", "kya", "kya" },
            new string[] { "kyu", "kyu", "kyu", "kyu", "kyu", "kyu" },
            new string[] { "kyo", "kyo", "kyo", "kyo", "kyo", "kyo" },
            // シャ行 (Sha-row)
            new string[] { "sha", "sha", "sha", "sha", "sha", "sha" },
            new string[] { "shu", "shu", "shu", "shu", "shu", "shu" },
            new string[] { "she", "she", "she", "she", "she", "she" },
            new string[] { "sho", "sho", "sho", "sho", "sho", "sho" },
            // チャ行 (Cha-row)
            new string[] { "cha", "cha", "cha", "cha", "cha", "cha" },
            new string[] { "chu", "chu", "chu", "chu", "chu", "chu" },
            new string[] { "che", "che", "che", "che", "che", "che" },
            new string[] { "cho", "cho", "cho", "cho", "cho", "cho" },
            // ニャ行 (Nya-row)
            new string[] { "nya", "nya", "nya", "nya", "nya", "nya" },
            new string[] { "nyu", "nyu", "nyu", "nyu", "nyu", "nyu" },
            new string[] { "nyo", "nyo", "nyo", "nyo", "nyo", "nyo" },
            // ヒャ行 (Hya-row)
            new string[] { "hya", "hya", "hya", "hya", "hya", "hya" },
            new string[] { "hyu", "hyu", "hyu", "hyu", "hyu", "hyu" },
            new string[] { "hyo", "hyo", "hyo", "hyo", "hyo", "hyo" },
            // ミャ行 (Mya-row)
            new string[] { "mya", "mya", "mya", "mya", "mya", "mya" },
            new string[] { "myu", "myu", "myu", "myu", "myu", "myu" },
            new string[] { "myo", "myo", "myo", "myo", "myo", "myo" },
            // リャ行 (Rya-row)
            new string[] { "rya", "rya", "rya", "rya", "rya", "rya" },
            new string[] { "ryu", "ryu", "ryu", "ryu", "ryu", "ryu" },
            new string[] { "ryo", "ryo", "ryo", "ryo", "ryo", "ryo" },
            // ギャ行 (Gya-row)
            new string[] { "gya", "gya", "gya", "gya", "gya", "gya" },
            new string[] { "gyu", "gyu", "gyu", "gyu", "gyu", "gyu" },
            new string[] { "gyo", "gyo", "gyo", "gyo", "gyo", "gyo" },
            // ジャ行 (Ja-row)
            new string[] { "ja", "ja", "ja", "ja", "ja", "ja" },
            new string[] { "ju", "ju", "ju", "ju", "ju", "ju" },
            new string[] { "je", "je", "je", "je", "je", "je" },
            new string[] { "jo", "jo", "jo", "jo", "jo", "jo" },
            // ビャ行 (Bya-row)
            new string[] { "bya", "bya", "bya", "bya", "bya", "bya" },
            new string[] { "byu", "byu", "byu", "byu", "byu", "byu" },
            new string[] { "byo", "byo", "byo", "byo", "byo", "byo" },
            // ピャ行 (Pya-row)
            new string[] { "pya", "pya", "pya", "pya", "pya", "pya" },
            new string[] { "pyu", "pyu", "pyu", "pyu", "pyu", "pyu" },
            new string[] { "pyo", "pyo", "pyo", "pyo", "pyo", "pyo" },
            // 外来音 (Gairaigo - Loan/foreign sounds)
            // ティ・トゥ行 (Ti/Tu-row)
            new string[] { "ti", "ti", "ti", "ti", "ti", "ti" },
            new string[] { "tu", "tu", "tu", "tu", "tu", "tu" },
            // ディ・ドゥ行 (Di/Du-row)
            new string[] { "di", "di", "di", "di", "di", "di" },
            new string[] { "du", "du", "du", "du", "du", "du" },
            // ファ行 (Fa-row)
            new string[] { "fa", "fa", "fa", "fa", "fa", "fa" },
            new string[] { "fu", "fu", "fu", "fu", "fu", "fu" },
            new string[] { "fyu", "fyu", "fyu", "fyu", "fyu", "fyu" },
            new string[] { "fe", "fe", "fe", "fe", "fe", "fe" },
            new string[] { "fo", "fo", "fo", "fo", "fo", "fo" },
            // ツァ行 (Tsa-row)
            new string[] { "tsa", "tsa", "tsa", "tsa", "tsa", "tsa" },
            new string[] { "tsi", "tsi", "tsi", "tsi", "tsi", "tsi" },
            new string[] { "tse", "tse", "tse", "tse", "tse", "tse" },
            // ウィ行 (Wi-row)
            new string[] { "wi", "wi", "wi", "wi", "wi", "wi" },
            new string[] { "we", "we", "we", "we", "we", "we" },
            new string[] { "wo", "wo", "wo", "wo", "wo", "wo" },
            // ヴァ行 (Va-row)
            new string[] { "va", "va", "va", "va", "va", "va" },
            new string[] { "vi", "vi", "vi", "vi", "vi", "vi" },
            new string[] { "vu", "vu", "vu", "vu", "vu", "vu" },
            new string[] { "ve", "ve", "ve", "ve", "ve", "ve" },
            new string[] { "vo", "vo", "vo", "vo", "vo", "vo" }
        };

        private readonly string[][] KanaWordsMeaning = new string[][] {
            // Hiragana
            // あ行 (A-row) - Contribution by Object777
            new string[] { "that thing over there", "over there", "tomorrow", "exist; have", "greeting", "thank you" },
            new string[] { "[negation] no", "when", "dog", "exist", "strawberry", "drink, eat, accept [polite]" },
            new string[] { "house, home", "behind; back", "above; on; over", "noodle", "noisy, annoying", "be glad; be happy; be delighted" },
            new string[] { "[affirmation] yes", "station", "shrimp", "English", "pencil", "yen" },
            new string [] { "Good morning", "adult", "delicious", "end", "interesting; fun", "toy"},
            // か行 (Ka-row) - Contribution by Object777
            new string[] { "umbrella", "bag", "face", "cute", "suspend; make (a phone call)", "however, but" },
            new string[] { "yesterday", "clean; beautiful", "kimono", "you [familiar]", "ticket", "dislike; hate" },
            new string[] { "Give me", "car", "shoe", "medicine", "How much", "repeat" },
            new string[] { "kick", "injury", "fight; argument", "but [particle]", "marriage", "distinction; demarcation" },
            new string[] { "language", "this way; this side; here", "child", "(uncooked) rice", "a covered table with a heat source underneath", "pepper" },
            // さ行 (Sa-row) - Contribution by Object777
            new string[] { "Goodbye", "Mr./Ms. Smith", "sashimi; raw fish", "sugar", "lonely; sad", "refreshing" },
            new string[] { "do", "did", "put away, finish", "salt", "tightly, reliable, firmly", "scold" },
            new string[] { "do", "sushi", "I'm sorry; Thank you", "right away, soon, immediately", "like", "terrific, amazing, terrible" },
            new string[] { "not do", "teacher; doctor", "laundry", "narrow; confined", "with special trouble or effort", "be in a hurry; be impatient" },
            new string[] { "that thing", "that place", "It's as you said", "buckwheat noodle; near, vicinity", "clean something", "slowly; soon; any time now" },
            // た行 (Ta-row) - Contribution by Nerazawa
            new string[] { "eat", "tatami; mat", "much; many", "free of charge; but; simply", "egg", "fun; enjoyable" },
            new string[] { "father; my father", "be different; be wrong", "basement", "small", "close", "this side; here" },
            new string[] { "next", "continue; to be continued", "pickles", "strong; sturdy", "boring; trifling", "plan; intention" },
            new string[] { "hand", "letter", "weather", "tempura", "help; lend a hand", "glove" },
            new string[] { "bird; chicken", "friend", "clock; watch", "very; extremely", "tōfu", "this thing and that thing near you" },
            // な行 (Na-row) - Contribution by Nerazawa
            new string[] { "not there; not exist", "why", "become", "pear", "dear; missed; familiar", "lose something" },
            new string[] { "Japan", "yard; garden", "carrot", "meat", "human being", "[particle indicating location] be here" },
            new string[] { "stuffed animal", "lukewarm; tepid", "take off (clothes, shoes, etc.)", "get wet", "paint; smear", "steal" },
            new string[] { "cat", "sleep", "sleepy", "price", "green onion; scallion", "pension; annuity" },
            new string[] { "dried seaweed; glue", "get on; ride", "left-over; remaining", "place on something; give a ride", "carefree; at leisure", "[particle connecting nouns] my house" },
            // は行 (Ha-row) - Contribution by Nerazawa
            new string[] { "[affirmation] yes; sure", "chopsticks", "talk; story", "See you later.", "actually", "I am Smith." },
            new string[] { "one unit", "person", "free time", "left", "awful; terrible", "pull; drag; lead" },
            new string[] { "two units", "futon", "bath", "fall (rain)", "touch", "wipe" },
            new string[] { "room", "unskillful; poor at", "decrease", "Please, this way.", "Where to?", "to everyone" },
            new string[] { "truth", "want; in need of", "mostly", "broom", "dust", "spinach" },
            // ま行 (Ma-row) - Contribution by Soup
            new string[] { "front; before", "[+negative] not yet, [+affirmation] still", "straight", "mimicry; pretense", "sleeping pillow", "diligent; serious" },
            new string[] { "green", "mandarin orange", "[polite] everyone", "right; right-hand side", "ear", "miso soup" },
            new string[] { "unreasonable; impossible", "daugther", "rice ball", "over there", "difficult", "humid; sultry" },
            new string[] { "eye", "cooked rice; meal", "noodles; mask", "eyeglasses", "troublesome,bothersome", "Congratulation!" },
            new string[] { "thing", "already, yet, no more", "if", "receive", "more", "popular" },
            // や行 (Ya-row) - Contribution by Soup
            new string[] { "do; give", "easy; kind", "yakitori (chicken dish)", "vacation, break, closed for business", "quit, stop", "noisy, annoying" },
            new string[] { "hot water, bath", "snow", "dream", "mail; postal service", "slowly, leisurely", "japanese citron; yuzu" },
            new string[] { "often, well, a lot", "side horizontal", "read", "night", "Best regards, Thank you in advance", "was good, Great!" },
            // ら行 (Ra-row) - Contribution by JustJaime
            new string[] { "that way; over there", "cherry blossom", "Welcome!", "apparently", "comfortable; easy; relaxing", "next year" },
            new string[] { "apple", "spendid; eminent", "need", "understanding", "divorce", "reason" },
            new string[] { "absence from home", "caretaker; house sitter", "during absence from home", "circle", "points of similarity", "some kind" },
            new string[] { "this", "expression of; gratitude", "practice", "history", "getting in touch; connection", "lotus root" },
            new string[] { "six", "corridor", "old person", "black", "white", "rather; instead" },
            // わ行 (Wa-row) - Contribution by JustJaime
            new string[] { "I; me", "understand", "break", "reason", "Japanese horseradish", "selfishness; self-indulgence" },
            new string[] { "Please give this to me.", "(I) ate sushi.", "(I) cleaned.", "(I) put on glasses.", "(I) greeted.", "Let's clean here." },
            new string[] { "everyone; all", "[affirmation/informal] yes", "Good day.", "female", "(not) at all", "manga comics" },
            // 濁音 (Dakuon - Voiced sounds)
            // が行 (Ga-row) - Contribution by Soup
            new string[] { "[particle indicating subject] This is good", "[clause particle] Excuse me...", "persevere, keep at it", "foreigner", "become disappointed", "endure" },
            new string[] { "bank", "key, lock", "rice ball", "obligation", "just barely", "limit" },
            new string[] { "condition", "idle complaint; grumble", "act tardily, hesitantly", "strike; hit", "by chance", "about, approximately (in quantity)" },
            new string[] { "vigorous, healthy", "entry hall", "diarrhea", "end of month", "language", "cause" },
            new string[] { "cooked rice; meal", "trash, dust", "It was delicious. (Thank you.)", "we have it.", "sesame", "[approximate point in time] about" },
             // ざ行 (Za-row) - Contribution by Soup
            new string[] { "flat floor cushion", "regrettable", "magazine", "sieve; bamboo strainer", "formal tatami room", "annoying [colloquial]" },
            new string[] { "time", "self", "accident", "earthquake", "bicycle", "selfish, self-centered [colloquial]" },
            new string[] { "sly; cunning", "awfully, very", "all the way, by far", "slip off", "move; put off", "trousers" },
            new string[] { "all; the whole thing", "wind, breeze, cold [illness]", "mix, stir, blend", "by all means", "absolutely", "whole; entirety" },
            new string[] { "please (speaker offering something)", "elephant", "know [honorific]", "zori (japanese sandals)", "belong; be affiliated with", "shiver; feeling chilly" },
            // だ行 (Da-row) - Contribution by Soup
            new string[] { "no good", "so; therefore", "gradually", "all right; safe", "university", "just, only" },
            new string[] { "shrink", "become wavy; become curly", "nosebleed", "near by; close by", "shortly; soon", "craft, cunning" },
            new string[] { "tidy up; put away", "keep up; continue something", "continue; go on", "spelling", "canned goods", "notice; recognize" },
            new string[] { "phone", "can do; come into being", "electricity; light", "go out", "[copula, formal] be", "nonsense; bullshit" },
            new string[] { "which one", "in every way; somehow; Thank you", "blunder, clumsiness [colloquial]", "where", "why", "thief" },
            // ば行 (Ba-row) - Contribution by Soup
            new string[] { "fool; absurd", "[celebratory] hurrah", "rose", "leak out; become exposed", "scattered; in pieces; disconnected", "only; little else but" },
            new string[] { "bottle; jar", "become surprised", "drenched", "delicate; subtle; questionable", "get cold feet; get frightened", "poor" },
            new string[] { "dangerous", "grapes", "pig", "commodity prices", "culture", "impolite; rude" },
            new string[] { "study", "box lunch", "separate; different", "separate", "convenient", "lawyer" },
            new string[] { "me, I (male term/language)", "hat", "worn out, tattered", "son, your son, young man [polite]", "stick, rod", "trade" },
            // ぱ行 (Pa-row) - Contribution by JustJaime
            new string[] { "pleasant clapping sound; incessant blinking", "falling in drops; pattering", "suddenly; in a flash", "sour; tart", "feeling refreshed; completely", "become stiff; act tough" },
            new string[] { "glitter; sparkle", "a little bit", "exactly; neatly", "spicy", "bent back; prone posture; weak-kneed", "sprawling; very spacious" },
            new string[] { "ten minutes", "electric fan", "resentment; grudge", "full stomach", "pretending not to know", "pregnant woman" },
            new string[] { "fluent; thin (paper)", "very hungry; being obsequious", "crushed flat", "chattering; chitchat", "top; peak", "once; a piece (of poetry)" },
            new string[] { "Japan", "walk; stroll", "ponzu sauce (Japanese vinegar)", "tail", "childish; child-like", "one-way traffic" },
            // 拗音 (Youon - Contracted sounds)
            // きゃ行 (Kya-row) - Contribution by Nerazawa
            new string[] { "guest; visitor, customer [plain]", "guest; visitor, customer [polite]", "guest room; cabin; (hotel) room", "incineration", "being overthrown", "objectively" },
            new string[] { "urgent; steep; sudden", "rest; break", "research", "ambulance", "cucumber", "school lunch" },
            new string[] { "today", "last year", "class room", "election", "distance", "interest (in something)" },
            // しゃ行 (Sha-row) - Contribution by Nerazawa
            new string[] { "photo", "speak, talk, chat", "society", "company employee", "shabu-shabu (Japanese hot pot dish)", "doctor" },
            new string[] { "hobby; tastes", "homework", "husband; my husband, proprietor (of a store), landlord, master", "kind, type", "week", "business trip" },
            new string[] { "soy sauce", "introduction", "nothing can be done", "[copula; tentative] probably be", "Let's do; why don't I do?", "elementary school" },
            // ちゃ行 (Cha-row) - Contribution by Object777
            new string[] { "tea", "[suffix added to children's names]", "proberly; neatly", "disorder, mess", "rice bowl, serving bowl", "brown hair, dyed hair" },
            new string[] { "caution; attention, advice", "China", "middle school", "lunch", "[phone] busy", "Chinese cuisine" },
            new string[] { "a bit, little", "exactly", "directly", "savings", "company president", "butterfly" },
            // にゃ行 (Nya-row) - Contribution by Object777
            new string[] { "kitty cat", "flabby; limp", "konjaku (jelly made from a vegetable)", "meow", "men and women of all ages", "limp; soft" },
            new string[] { "input; data entry", "entry to school", "joining (a group)", "hospitalization", "fill in forms", "mammal" },
            new string[] { "urine", "urinary test, urine examination", "wife; my wife", "married man", "[tree, plant] shooting up one after another", "wriggling; slithering" },
            // ひゃ行 (Hya-row) - Contribution by Soup
            new string[] { "hundred", "hundred years old", "hundred years", "two hundred yen", "department store", "encyclopedia" },
            new string[] { "whistling sound; sound of wind" },
            new string[] { "evaluation; assess", "reputation; fame; popularity", "chart", "schedule, itinerary", "facetious, funny", "frail; lanky" },
            // みゃ行 (Mya-row) - Contribution by Soup/Yuka ゆか & Reava_
            new string[] { "pulse", "personal connection", "mountain range", "continuous, unbroken", "context", "[medical term] artery" },
            new string[] { "civilian (non-military person)", "music theory" },
            new string[] { "tomorrow", "tomorrow morning", "day after tomorrow", "surname", "strange", "life span" },
            // りゃ行 (Rya-row) - Contribution by Soup/Yuka ゆか
            new string[] { "abbreviation", "acronym; abbreviation", "simplified character", "brief personal record", "omission; abbreviation", "salutation of brief letter (lit. 'first part omitted')" },
            new string[] { "studying abroad", "international exchange student", "fashion; fad", "mainstream", "self-taught manner", "japanese style" },
            new string[] { "travel; trip", "cooking; cuisine", "both parents", "japanese inn", "document; materials; data", "dormitory" },
            // ぎゃ行 (Gya-row) - Contribution by Soup/Yuka ゆか
            new string[] { "reverse; opposite", "abuse, ill-treatment", "paradox", "turn-around; reversal", "go backward; backlighting", "adversity" },
            new string[] { "milk", "beef", "packing tight; creaking", "tightly; hard (e.g., a grab)", "rice dish with beef", "control; have under one's thumb" },
            new string[] { "manner; behavior", "event, function", "line, row", "industry, business", "fishing industry", "goldfish" },
            // じゃ行 (Ja-row) - Contribution by Soup/Yuka ゆか
            new string[] { "then; well [combination of de and wa]", "nuisance; bother", "see you", "(it) is not", "rock, paper, scissors game", "something happening nonstop" },
            new string[] { "school time; class time", "address", "ten", "order of things; turn (in line)", "important; principal", "professor" },
            new string[] { "skillful; skilled", "woman; female", "joke", "assistant", "actress", "gradually, little by little" },
            // ぢゃ行 (Dja-row) - Contribution by Soup/Yuka ゆか
            new string[] { "(japanese) tea cup", "ticket agent for sumō", "faucet, tap", "hindrance, nuisance", "gravel", "jump" },
            new string[] { "*" },
            new string[] { "*" },
            // びゃ行 (Bya-row) - Contribution by Soup/Yuka ゆか
            new string[] { "three hundred", "how many hundred yen" },
            new string[] { "Howl (sound of wind)" },
            new string[] { "sick; sickness", "hospital" },
            // ぴゃ行 (Pya-row) - Contribution by Soup/Yuka ゆか
            new string[] { "six hundred", "eight hundred", "all sorts of lies; tissue of lies" },
            new string[] { "sound of whistling" },
            new string[] { "announcement, presentation", "sales slip, voucher" },
    
            // Katakana
            // ア行 (A-row) - Contribution by Object777
            new string[] { "America; U.S.A", "animation; cartoon", "access", "address", "ice cream", "apartment" },
            new string[] { "internet", "event", "image", "India", "Italian", "good-looking man; cool guy" },
            new string[] { "wool", "virus", "woman", "west", "whisky", "wink" },
            new string[] { "air conditioner", "energy", "ecology", "elite", "error", "Excel" },
            new string[] { "open", "orange", "oil", "online", "oven", "Australia" },
            // カ行 (Ka-row) - Contribution by Object777
            new string[] { "card", "color", "calorie", "café", "curry", "car navigation system" },
            new string[] { "kitchen", "keyboard", "kiss", "kids", "Christ", "key word" },
            new string[] { "club", "air conditioner", "cookie", "cool", "claim", "Christmas" },
            new string[] { "cell phone", "cake", "case", "ketchup", "market", "skate" },
            new string[] { "coffee", "cost", "comic book", "convenience store", "cup, glass, tumbler", "community" },
            // サ行 (Sa-row) - Contribution by Object777
            new string[] { "service", "salad", "site; website", "sandwich", "soccer", "sunglasses" },
            new string[] { "system", "simple", "seat", "series", "season", "single" },
            new string[] { "sport", "style", "stop", "start", "strawberry", "spice" },
            new string[] { "(shopping, medical) center", "sale", "sense", "sweater", "seminar", "wealthy socialite" },
            new string[] { "sauce (Worcestershire sauce)", "soft, software", "song", "socks", "Soul (soul music)", "sofa" },
            // タ行 (Ta-row) - Contribution by Object777
            new string[] { "taxi", "time", "towel", "Thailand, necktie", "tower", "timing" },
            new string[] { "chicken", "cheese", "team", "ticket", "(potato) chip", "Chile" },
            new string[] { "tour", "tree", "tuna", "tool", "bed sheets", "sweets; dessert" },
            new string[] { "TV; television", "table", "tennis", "test", "theme", "terrorism" },
            new string[] { "toast", "tomato", "top", "trend", "total", "training" },
            // ナ行 (Na-row) - Contribution by Object777
            new string[] { "number", "nice", "night", "knife", "napkin", "navigation" },
            new string[] { "need", "knit", "NEET (young people Not in Education, Employment or Training)", "monitor", "sneakers", "vanilla" },
            new string[] { "noodle", "nude", "canoe", "Seine (river)", "Cezanne", "Sorbonne" },
            new string[] { "net, Internet", "name", "necktie", "neck, obstacle", "negative", "necklace" },
            new string[] { "note", "sugarless", "laptop computer", "non-stop", "Norway", "alcohol-free" },
            // ハ行 (Ha-row) - Contribution by Object777
            new string[] { "high technology", "government employment agency", "heart", "handkerchief", "Hawaii", "Harvard Univ." },
            new string[] { "hit", "heat", "hint", "heel", "hero", "Himalaya" },
            new string[] { "fruit", "young people subsisting on part-time work", "French fries", "France", "flash", "food" },
            new string[] { "healthy", "hair", "hair style", "help", "helicopter", "helmet" },
            new string[] { "homepage", "hotel", "hot", "hall", "holiday", "Hong Kong" },
            // マ行 (Ma-row) - Contribution by Object777
            new string[] { "'large' apartment; modern apartment house", "mayonnaise", "media", "manner", "one-on-one", "marketing" },
            new string[] { "mistake", "mix", "meeting", "milk", "mini", "meat ball" },
            new string[] { "game", "movie", "mood", "ham", "dome", "mouse" },
            new string[] { "email; text message", "menu", "member", "memory card", "memo", "men's; menswear" },
            new string[] { "model", "mall", "modern", "monorail", "monster", "Mongolia" },
            // ヤ行 (Ya-row) - Contribution by Object777
            new string[] { "young", "Japanese punk", "earring", "diamond", "tire", "taxi; limo" },
            new string[] { "user", "unique", "humor", "Euro (currency)", "Jewish", "Yugoslavia" },
            new string[] { "Europe", "yogurt", "yacht", "yoyo", "Jordan", "crayon" },
            // ラ行 (Ra-row) - Contribution by Object777
            new string[] { "lunch", "ramen", "love", "light", "ranking", "live performance" },
            new string[] { "recycle", "restructuring; downsizing", "lead", "living", "resort", "league" },
            new string[] { "rule", "report", "root", "route", "school", "beer" },
            new string[] { "restaurant", "receipt", "lesson", "recipe", "lettuce", "laser" },
            new string[] { "login", "locker", "robot", "loan", "London", "Russia" },
            // ワ行 (Wa-row) - Contribution by Object777
            new string[] { "wine", "world", "dress shirt", "vaccine", "1-Seg (digital broadcasting service for mobile devices)", "word" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // 濁音 (Dakuon - Voiced sounds)
            // ガ行 (Ga-row) - Contribution by Object777
            new string[] { "guide", "gas", "gasoline", "glass; pane", "gardening", "garage" },
            new string[] { "gift", "guitar", "Greece", "gear", "Guinness Book of Records", "ideology" },
            new string[] { "gourmet", "green", "goods", "Guam", "(sports) playing field", "Mother Goose" },
            new string[] { "game", "guest", "game center", "gate", "gay", "collagen" },
            new string[] { "goal", "rubber", "Godzilla", "Golden Week (early May holiday season)", "(Okinawan) bitter melon", "Chicago" },
            // ザ行 (Za-row) - Contribution by Object777
            new string[] { "pizza", "leather", "Elizabeth", "Gaza Strip", "laser", "mother" },
            new string[] { "jeans", "gym", "gin", "digital", "music", "chimpanzee" },
            new string[] { "trousers", "zoom", "puzzle", "rose", "zucchini", "shoes" },
            new string[] { "zero", "seminar", "general contractor", "rose wine", "gelatin", "number worn by athletes" },
            new string[] { "zone", "Arizona", "Amazon", "exotic", "zombie", "ozone" },
            // ダ行 (Da-row) - Contribution by Object777
            new string[] { "dance", "diet", "tick; mite", "download", "double", "diving" },
            new string[] { "data", "department store", "design", "date", "dessert", "digital camera" },
            new string[] { "door", "drama", "(salad) dressing", "drug store", "dotcom", "hard" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // バ行 (Ba-row) - Contribution by Object777
            new string[] { "bus; bath", "bag", "bar", "banana", "motorcycle", "birthday" },
            new string[] { "plastic; vinyl", "business", "vitamin", "video", "building", "visa" },
            new string[] { "brand", "boom", "broccoli", "blueberry", "bra", "swing" },
            new string[] { "best; vest", "bed", "belt", "balcony", "person with a lot of experience", "stroller" },
            new string[] { "ball", "bottle", "boat", "boss", "volunteer", "button" },
            // パ行 (Pa-row) - Contribution by Object777
            new string[] { "bread", "personal computer", "passport", "part-time", "PowerPoint", "Paris" },
            new string[] { "focus point", "piano", "pink", "earrings for pierced ears", "green pepper", "pitcher" },
            new string[] { "present", "professional", "program", "printer", "profile", "private" },
            new string[] { "pet", "pen", "page", "paint", "Peru", "pepper" },
            new string[] { "point", "post; mailbox", "poster", "pocket", "hot water machine; pot", "pop music; popular" },
            // 拗音 (Youon - Contracted sounds)
            // キャ行 (Kya-row) - Contribution by Object777
            new string[] { "career", "cabbage", "character", "cashing, take out small loans", "captain", "catcher" },
            new string[] { "BBQ", "security", "Cuba", "cute", "Thank you", "rescue" },
            new string[] { "", "", "", "", "", "" },
            // シャ行 (Sha-row) - Contribution by Object777
            new string[] { "shirt", "shampoo", "shower", "champagne", "shy", "musician" },
            new string[] { "sugar", "cream puffs", "shoot", "push", "Chinese dumpling", "mushroom" },
            new string[] { "chef", "(milk) shake", "share", "(electric) shaver", "Shakespeare", "sherry" },
            new string[] { "shop", "show", "shopping", "shock", "shoulder bag", "cushion" },
            // チャ行 (Cha-row) - Contribution by Object777
            new string[] { "channel", "chance", "champion", "chapel", "child", "charming" },
            new string[] { "tulip", "chewing gum", "tuner", "tube", "stew", "student" },
            new string[] { "check in", "chain", "cherry", "change", "chess", "check; plaid" },
            new string[] { "chocolate", "choice", "chalk", "question", "chop", "place mat" },
            // ニャ行 (Nya-row) - Contribution by Object777
            new string[] { "cognac", "kitty cat", "jelly made of a root vegetable", "Catalonia", "Bologna", "bagna cauda (Italian sauce)" },
            new string[] { "news", "New York", "new", "new town", "New Zealand", "nuance" },
            new string[] { "El Niño", "gnocci", "mushroom (French)", "jalapeño pepper", "Avignon", "nuoc mam (Vietnamese fish sauce)" },
            // ヒャ行 (Hya-row) - Contribution by Object777
            new string[] { "", "", "", "", "", "" },
            new string[] { "human", "hues", "humanism", "perfume", "Houston", "Lake Huron" },
            new string[] { "", "", "", "", "", "" },
            // ミャ行 (Mya-row) - Contribution by Object777
            new string[] { "", "", "", "", "", "" },
            new string[] { "museum", "musical", "Munich", "Bermuda", "Samuel", "amusement" },
            new string[] { "", "", "", "", "", "" },
            // リャ行 (Rya-row) - Contribution by Object777
            new string[] { "Castille (Spain)", "kaoliang (plant)", "paella (Spanish rice dish)", "", "", "" },
            new string[] { "rucksack; backpack", "rheumatism", "revolution", "volume", "solution", "screw" },
            new string[] { "matryoshka (Russian nesting doll)", "", "", "", "", "" },
            // ギャ行 (Gya-row) - Contribution by Object777
            new string[] { "girl; gal", "gamble", "prank; joke", "gang", "gallery", "pay for performance" },
            new string[] { "regular", "figure", "figure skating", "irregular", "regulator", "" },
            new string[] { "Japanese/Chinese dumpling", "", "", "", "", "" },
            // ジャ行 (Ja-row) - Contribution by Object777
            new string[] { "jam", "jacket", "jazz", "genre", "journal", "jump" },
            new string[] { "junior", "juice", "jewelry", "Geneva", "collage", "rouge; lipstick" },
            new string[] { "jet", "jelly, Jerry", "jealousy", "gesture", "item of artwork", "James" },
            new string[] { "joke", "jogging", "beer mug", "", "", "" },
            // ビャ行 (Bya-row) - Contribution by Object777
            new string[] { "", "", "", "", "", "" },
            new string[] { "beauty", "interview", "buffet", "eyelash curler", "review", "debut" },
            new string[] { "", "", "", "", "", "" },
            // ピャ行 (Pya-row) - Contribution by Object777
            new string[] { "", "", "", "", "", "" },
            new string[] { "popular", "pure", "puma", "Pulitzer Prize", "puree", "" },
            new string[] { "Pyongyang", "Peter (Russian)", "", "", "", "" },
            // 外来音 (Gairaigo - Loan/foreign sounds)
            // ティ・トゥ行 (Ti/Tu-row) - Contribution by Object777
            new string[] { "tea", "party", "tissue", "identity", "pastry chef", "variety" },
            new string[] { "tuba", "institute", "tuition", "", "", "" },
            // ディ・ドゥ行 (Di/Du-row) - Contribution by Object777
            new string[] { "dinner", "deep", "melody", "parody", "director", "disk" },
            new string[] { "dual", "education", "fondue", "duet", "producer", "duo" },
            // ファ行 (Fa-row) - Contribution by Object777
            new string[] { "family", "fashion", "fax", "fight", "", "" },
            new string[] { "fish", "film", "feet", "fiction", "", "" },
            new string[] { "manifesto; political pledge", "feminine", "fence", "fair play", "", "" },
            new string[] { "folk; fork", "form", "forum", "foie gras", "", "" },
            new string[] { "", "", "", "", "", "" },
            // ツァ行 (Tsa-row) - Contribution by Object777
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // ウィ行 (Wi-row) - Contribution by Object777
            new string[] { "week", "window", "wig", "vienna sausage", "sandwich", "Halloween" },
            new string[] { "welcome", "Kuwait", "wedding", "Wednesday", "", "" },
            new string[] { "walking", "Wall Street", "warm up", "water", "", "" },
            // ヴァ行 (Va-row) - Contribution by Object777
            new string[] { "violin", "variation", "virgin", "violet", "Vivaldi", "vacation" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" }
        };

        #endregion
