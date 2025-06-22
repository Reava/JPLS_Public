        private readonly string[][] KanaWords = new string[][] {
            // Hiragana
            // あ行 (A-row) - Contribution by Object777
            new string[] { "are", "asoko", "ashita", "arimasu", "aisatsu", "arigatō" },
            new string[] { "iie", "itsu", "inu", "iru", "ichigo", "itadakimasu" },
            new string[] { "uchi", "ushiro", "ue", "udon", "urusai", "ureshii" },
            new string[] { "ee", "eki", "ebi", "eigo", "enpitsu", "en" },
            new string[] { "ohayō", "otona", "oishii", "owari", "omoshiroi", "omocha" },
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
            // ま行 (Ma-row)
            new string[] { "ま", "ま", "ま", "ま", "ま", "ま" },
            new string[] { "み", "み", "み", "み", "み", "み" },
            new string[] { "む", "む", "む", "む", "む", "む" },
            new string[] { "め", "め", "め", "め", "め", "め" },
            new string[] { "も", "も", "も", "も", "も", "も" },
            // や行 (Ya-row)
            new string[] { "や", "や", "や", "や", "や", "や" },
            new string[] { "ゆ", "ゆ", "ゆ", "ゆ", "ゆ", "ゆ" },
            new string[] { "よ", "よ", "よ", "よ", "よ", "よ" },
            // ら行 (Ra-row)
            new string[] { "ら", "ら", "ら", "ら", "ら", "ら" },
            new string[] { "り", "り", "り", "り", "り", "り" },
            new string[] { "る", "る", "る", "る", "る", "る" },
            new string[] { "れ", "れ", "れ", "れ", "れ", "れ" },
            new string[] { "ろ", "ろ", "ろ", "ろ", "ろ", "ろ" },
            // わ行 (Wa-row)
            new string[] { "わ", "わ", "わ", "わ", "わ", "わ" },
            new string[] { "を", "を", "を", "を", "を", "を" },
            new string[] { "ん", "ん", "ん", "ん", "ん", "ん" },
            // 濁音 (Dakuon - Voiced sounds)
            // が行 (Ga-row)
            new string[] { "が", "が", "が", "が", "が", "が" },
            new string[] { "ぎ", "ぎ", "ぎ", "ぎ", "ぎ", "ぎ" },
            new string[] { "ぐ", "ぐ", "ぐ", "ぐ", "ぐ", "ぐ" },
            new string[] { "げ", "げ", "げ", "げ", "げ", "げ" },
            new string[] { "ご", "ご", "ご", "ご", "ご", "ご" },
            // ざ行 (Za-row)
            new string[] { "ざ", "ざ", "ざ", "ざ", "ざ", "ざ" },
            new string[] { "じ", "じ", "じ", "じ", "じ", "じ" },
            new string[] { "ず", "ず", "ず", "ず", "ず", "ず" },
            new string[] { "ぜ", "ぜ", "ぜ", "ぜ", "ぜ", "ぜ" },
            new string[] { "ぞ", "ぞ", "ぞ", "ぞ", "ぞ", "ぞ" },
            // だ行 (Da-row)
            new string[] { "だ", "だ", "だ", "だ", "だ", "だ" },
            new string[] { "ぢ", "ぢ", "ぢ", "ぢ", "ぢ", "ぢ" },
            new string[] { "づ", "づ", "づ", "づ", "づ", "づ" },
            new string[] { "で", "で", "で", "で", "で", "で" },
            new string[] { "ど", "ど", "ど", "ど", "ど", "ど" },
            // ば行 (Ba-row)
            new string[] { "ば", "ば", "ば", "ば", "ば", "ば" },
            new string[] { "び", "び", "び", "び", "び", "び" },
            new string[] { "ぶ", "ぶ", "ぶ", "ぶ", "ぶ", "ぶ" },
            new string[] { "べ", "べ", "べ", "べ", "べ", "べ" },
            new string[] { "ぼ", "ぼ", "ぼ", "ぼ", "ぼ", "ぼ" },
            // ぱ行 (Pa-row)
            new string[] { "ぱ", "ぱ", "ぱ", "ぱ", "ぱ", "ぱ" },
            new string[] { "ぴ", "ぴ", "ぴ", "ぴ", "ぴ", "ぴ" },
            new string[] { "ぷ", "ぷ", "ぷ", "ぷ", "ぷ", "ぷ" },
            new string[] { "ぺ", "ぺ", "ぺ", "ぺ", "ぺ", "ぺ" },
            new string[] { "ぽ", "ぽ", "ぽ", "ぽ", "ぽ", "ぽ" },
            // 拗音 (Youon - Contracted sounds)
            // きゃ行 (Kya-row)
            new string[] { "きゃ", "きゃ", "きゃ", "きゃ", "きゃ", "きゃ" },
            new string[] { "きゅ", "きゅ", "きゅ", "きゅ", "きゅ", "きゅ" },
            new string[] { "きょ", "きょ", "きょ", "きょ", "きょ", "きょ" },
            // しゃ行 (Sha-row)
            new string[] { "しゃ", "しゃ", "しゃ", "しゃ", "しゃ", "しゃ" },
            new string[] { "しゅ", "しゅ", "しゅ", "しゅ", "しゅ", "しゅ" },
            new string[] { "しょ", "しょ", "しょ", "しょ", "しょ", "しょ" },
            // ちゃ行 (Cha-row)
            new string[] { "ちゃ", "ちゃ", "ちゃ", "ちゃ", "ちゃ", "ちゃ" },
            new string[] { "ちゅ", "ちゅ", "ちゅ", "ちゅ", "ちゅ", "ちゅ" },
            new string[] { "ちょ", "ちょ", "ちょ", "ちょ", "ちょ", "ちょ" },
            // にゃ行 (Nya-row)
            new string[] { "にゃ", "にゃ", "にゃ", "にゃ", "にゃ", "にゃ" },
            new string[] { "にゅ", "にゅ", "にゅ", "にゅ", "にゅ", "にゅ" },
            new string[] { "にょ", "にょ", "にょ", "にょ", "にょ", "にょ" },
            // ひゃ行 (Hya-row)
            new string[] { "ひゃ", "ひゃ", "ひゃ", "ひゃ", "ひゃ", "ひゃ" },
            new string[] { "ひゅ", "ひゅ", "ひゅ", "ひゅ", "ひゅ", "ひゅ" },
            new string[] { "ひょ", "ひょ", "ひょ", "ひょ", "ひょ", "ひょ" },
            // みゃ行 (Mya-row)
            new string[] { "みゃ", "みゃ", "みゃ", "みゃ", "みゃ", "みゃ" },
            new string[] { "みゅ", "みゅ", "みゅ", "みゅ", "みゅ", "みゅ" },
            new string[] { "みょ", "みょ", "みょ", "みょ", "みょ", "みょ" },
            // りゃ行 (Rya-row)
            new string[] { "りゃ", "りゃ", "りゃ", "りゃ", "りゃ", "りゃ" },
            new string[] { "りゅ", "りゅ", "りゅ", "りゅ", "りゅ", "りゅ" },
            new string[] { "りょ", "りょ", "りょ", "りょ", "りょ", "りょ" },
            // ぎゃ行 (Gya-row)
            new string[] { "ぎゃ", "ぎゃ", "ぎゃ", "ぎゃ", "ぎゃ", "ぎゃ" },
            new string[] { "ぎゅ", "ぎゅ", "ぎゅ", "ぎゅ", "ぎゅ", "ぎゅ" },
            new string[] { "ぎょ", "ぎょ", "ぎょ", "ぎょ", "ぎょ", "ぎょ" },
            // じゃ行 (Ja-row)
            new string[] { "じゃ", "じゃ", "じゃ", "じゃ", "じゃ", "じゃ" },
            new string[] { "じゅ", "じゅ", "じゅ", "じゅ", "じゅ", "じゅ" },
            new string[] { "じょ", "じょ", "じょ", "じょ", "じょ", "じょ" },
            // ぢゃ行 (Dja-row)
            new string[] { "ぢゃ", "ぢゃ", "ぢゃ", "ぢゃ", "ぢゃ", "ぢゃ" },
            new string[] { "ぢゅ", "ぢゅ", "ぢゅ", "ぢゅ", "ぢゅ", "ぢゅ" },
            new string[] { "ぢょ", "ぢょ", "ぢょ", "ぢょ", "ぢょ", "ぢょ" },
            // びゃ行 (Bya-row)
            new string[] { "びゃ", "びゃ", "びゃ", "びゃ", "びゃ", "びゃ" },
            new string[] { "びゅ", "びゅ", "びゅ", "びゅ", "びゅ", "びゅ" },
            new string[] { "びょ", "びょ", "びょ", "びょ", "びょ", "びょ" },
            // ぴゃ行 (Pya-row)
            new string[] { "ぴゃ", "ぴゃ", "ぴゃ", "ぴゃ", "ぴゃ", "ぴゃ" },
            new string[] { "ぴゅ", "ぴゅ", "ぴゅ", "ぴゅ", "ぴゅ", "ぴゅ" },
            new string[] { "ぴょ", "ぴょ", "ぴょ", "ぴょ", "ぴょ", "ぴょ" },
            
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
            new string[] { "that thing over there", "over there", "tomorrow", "exist; have", "greeting", "thank you" },
            new string[] { "[negation] no", "when", "dog", "exist", "strawberry", "drink, eat, accept [polite]" },
            new string[] { "house, home", "behind; back", "above; on; over", "noodle", "noisy, annoying", "be glad; be happy; be delighted" },
            new string[] { "[affirmation] yes", "station", "shrimp", "English", "pencil", "yen" },
            new string [] { "Good morning", "adult", "delicious", "end", "interesting; fun", "toy"},
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
            // ま行 (Ma-row)
            new string[] { "ma", "ma", "ma", "ma", "ma", "ma" },
            new string[] { "mi", "mi", "mi", "mi", "mi", "mi" },
            new string[] { "mu", "mu", "mu", "mu", "mu", "mu" },
            new string[] { "me", "me", "me", "me", "me", "me" },
            new string[] { "mo", "mo", "mo", "mo", "mo", "mo" },
            // や行 (Ya-row)
            new string[] { "ya", "ya", "ya", "ya", "ya", "ya" },
            new string[] { "yu", "yu", "yu", "yu", "yu", "yu" },
            new string[] { "yo", "yo", "yo", "yo", "yo", "yo" },
            // ら行 (Ra-row)
            new string[] { "ra", "ra", "ra", "ra", "ra", "ra" },
            new string[] { "ri", "ri", "ri", "ri", "ri", "ri" },
            new string[] { "ru", "ru", "ru", "ru", "ru", "ru" },
            new string[] { "re", "re", "re", "re", "re", "re" },
            new string[] { "ro", "ro", "ro", "ro", "ro", "ro" },
            // わ行 (Wa-row)
            new string[] { "wa", "wa", "wa", "wa", "wa", "wa" },
            new string[] { "wo", "wo", "wo", "wo", "wo", "wo" },
            new string[] { "n", "n", "n", "n", "n", "n" },
            // 濁音 (Dakuon - Voiced sounds)
            // が行 (Ga-row)
            new string[] { "ga", "ga", "ga", "ga", "ga", "ga" },
            new string[] { "gi", "gi", "gi", "gi", "gi", "gi" },
            new string[] { "gu", "gu", "gu", "gu", "gu", "gu" },
            new string[] { "ge", "ge", "ge", "ge", "ge", "ge" },
            new string[] { "go", "go", "go", "go", "go", "go" },
            // ざ行 (Za-row)
            new string[] { "za", "za", "za", "za", "za", "za" },
            new string[] { "ji", "ji", "ji", "ji", "ji", "ji" },
            new string[] { "zu", "zu", "zu", "zu", "zu", "zu" },
            new string[] { "ze", "ze", "ze", "ze", "ze", "ze" },
            new string[] { "zo", "zo", "zo", "zo", "zo", "zo" },
            // だ行 (Da-row)
            new string[] { "da", "da", "da", "da", "da", "da" },
            new string[] { "ji", "ji", "ji", "ji", "ji", "ji" },
            new string[] { "zu", "zu", "zu", "zu", "zu", "zu" },
            new string[] { "de", "de", "de", "de", "de", "de" },
            new string[] { "do", "do", "do", "do", "do", "do" },
            // ば行 (Ba-row)
            new string[] { "ba", "ba", "ba", "ba", "ba", "ba" },
            new string[] { "bi", "bi", "bi", "bi", "bi", "bi" },
            new string[] { "bu", "bu", "bu", "bu", "bu", "bu" },
            new string[] { "be", "be", "be", "be", "be", "be" },
            new string[] { "bo", "bo", "bo", "bo", "bo", "bo" },
            // ぱ行 (Pa-row)
            new string[] { "pa", "pa", "pa", "pa", "pa", "pa" },
            new string[] { "pi", "pi", "pi", "pi", "pi", "pi" },
            new string[] { "pu", "pu", "pu", "pu", "pu", "pu" },
            new string[] { "pe", "pe", "pe", "pe", "pe", "pe" },
            new string[] { "po", "po", "po", "po", "po", "po" },
            // 拗音 (Youon - Contracted sounds)
            // きゃ行 (Kya-row)
            new string[] { "kya", "kya", "kya", "kya", "kya", "kya" },
            new string[] { "kyu", "kyu", "kyu", "kyu", "kyu", "kyu" },
            new string[] { "kyo", "kyo", "kyo", "kyo", "kyo", "kyo" },
            // しゃ行 (Sha-row)
            new string[] { "sha", "sha", "sha", "sha", "sha", "sha" },
            new string[] { "shu", "shu", "shu", "shu", "shu", "shu" },
            new string[] { "sho", "sho", "sho", "sho", "sho", "sho" },
            // ちゃ行 (Cha-row)
            new string[] { "cha", "cha", "cha", "cha", "cha", "cha" },
            new string[] { "chu", "chu", "chu", "chu", "chu", "chu" },
            new string[] { "cho", "cho", "cho", "cho", "cho", "cho" },
            // にゃ行 (Nya-row)
            new string[] { "nya", "nya", "nya", "nya", "nya", "nya" },
            new string[] { "nyu", "nyu", "nyu", "nyu", "nyu", "nyu" },
            new string[] { "nyo", "nyo", "nyo", "nyo", "nyo", "nyo" },
            // ひゃ行 (Hya-row)
            new string[] { "hya", "hya", "hya", "hya", "hya", "hya" },
            new string[] { "hyu", "hyu", "hyu", "hyu", "hyu", "hyu" },
            new string[] { "hyo", "hyo", "hyo", "hyo", "hyo", "hyo" },
            // みゃ行 (Mya-row)
            new string[] { "mya", "mya", "mya", "mya", "mya", "mya" },
            new string[] { "myu", "myu", "myu", "myu", "myu", "myu" },
            new string[] { "myo", "myo", "myo", "myo", "myo", "myo" },
            // りゃ行 (Rya-row)
            new string[] { "rya", "rya", "rya", "rya", "rya", "rya" },
            new string[] { "ryu", "ryu", "ryu", "ryu", "ryu", "ryu" },
            new string[] { "ryo", "ryo", "ryo", "ryo", "ryo", "ryo" },
            // ぎゃ行 (Gya-row)
            new string[] { "gya", "gya", "gya", "gya", "gya", "gya" },
            new string[] { "gyu", "gyu", "gyu", "gyu", "gyu", "gyu" },
            new string[] { "gyo", "gyo", "gyo", "gyo", "gyo", "gyo" },
            // じゃ行 (Ja-row)
            new string[] { "ja", "ja", "ja", "ja", "ja", "ja" },
            new string[] { "ju", "ju", "ju", "ju", "ju", "ju" },
            new string[] { "jo", "jo", "jo", "jo", "jo", "jo" },
            // ぢゃ行 (Dja-row)
            new string[] { "ja", "ja", "ja", "ja", "ja", "ja" },
            new string[] { "ju", "ju", "ju", "ju", "ju", "ju" },
            new string[] { "jo", "jo", "jo", "jo", "jo", "jo" },
            // びゃ行 (Bya-row)
            new string[] { "bya", "bya", "bya", "bya", "bya", "bya" },
            new string[] { "byu", "byu", "byu", "byu", "byu", "byu" },
            new string[] { "byo", "byo", "byo", "byo", "byo", "byo" },
            // ぴゃ行 (Pya-row)
            new string[] { "pya", "pya", "pya", "pya", "pya", "pya" },
            new string[] { "pyu", "pyu", "pyu", "pyu", "pyu", "pyu" },
            new string[] { "pyo", "pyo", "pyo", "pyo", "pyo", "pyo" },
            
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
            // ま行 (Ma-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // や行 (Ya-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // ら行 (Ra-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // わ行 (Wa-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // 濁音 (Dakuon - Voiced sounds)
            // が行 (Ga-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // ざ行 (Za-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // だ行 (Da-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // ば行 (Ba-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // ぱ行 (Pa-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // 拗音 (Youon - Contracted sounds)
            // きゃ行 (Kya-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // しゃ行 (Sha-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // ちゃ行 (Cha-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // にゃ行 (Nya-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // ひゃ行 (Hya-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // みゃ行 (Mya-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // りゃ行 (Rya-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // ぎゃ行 (Gya-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // じゃ行 (Ja-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // ぢゃ行 (Dja-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // びゃ行 (Bya-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // ぴゃ行 (Pya-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
    
            // Katakana
            // ア行 (A-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // カ行 (Ka-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // サ行 (Sa-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // タ行 (Ta-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // ナ行 (Na-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // ハ行 (Ha-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // マ行 (Ma-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // ヤ行 (Ya-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // ラ行 (Ra-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // ワ行 (Wa-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // 濁音 (Dakuon - Voiced sounds)
            // ガ行 (Ga-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // ザ行 (Za-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // ダ行 (Da-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // バ行 (Ba-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // パ行 (Pa-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // 拗音 (Youon - Contracted sounds)
            // キャ行 (Kya-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // シャ行 (Sha-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // チャ行 (Cha-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // ニャ行 (Nya-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // ヒャ行 (Hya-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // ミャ行 (Mya-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // リャ行 (Rya-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // ギャ行 (Gya-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // ジャ行 (Ja-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // ビャ行 (Bya-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // ピャ行 (Pya-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // 外来音 (Gairaigo - Loan/foreign sounds)
            // ティ・トゥ行 (Ti/Tu-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // ディ・ドゥ行 (Di/Du-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // ファ行 (Fa-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // ツァ行 (Tsa-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // ウィ行 (Wi-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // ヴァ行 (Va-row)
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" }
        };
