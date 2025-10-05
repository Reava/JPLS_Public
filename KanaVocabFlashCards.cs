
        #region VocabKana

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
            new string[] { "ひゅうひゅう", "", "", "", "", "" }, // NO FILL
            new string[] { "ひょうか", "ひょうばん", "ひょう", "よていひょう", "ひょうきん", "ひょろひょろ" },
            // みゃ行 (Mya-row) - Contribution by Soup/Yuka ゆか
            new string[] { "まいく", "じんみゃく", "さんみゃく", "みゃくみゃく", "ぶんみゃく", "どうみゃく" },
            new string[] { "みゅうじん", "みゅうと", "みゅうじかる", "みゅうじあむ", "みゅうがく", "" }, // NO FILL
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
            new string[] { "", "", "", "", "", "" }, // NO FILL
            new string[] { "", "", "", "", "", "" }, // NO FILL
            // びゃ行 (Bya-row) - Contribution by Soup/Yuka ゆか
            new string[] { "さんびゃく", "なんびゃくえん", "", "", "", "" }, // NO FILL
            new string[] { "びゅうびゅう", "", "", "", "", "" }, // NO FILL
            new string[] { "びょうき", "びょういん", "", "", "", "" }, // NO FILL
            // ぴゃ行 (Pya-row) - Contribution by Soup/Yuka ゆか
            new string[] { "ろっぴゃく", "はっぴゃく", "うそはっぴゃく", "", "", "" }, // NO FILL
            new string[] { "ぴゅうぴゅう", "", "", "", "", "" }, // NO FILL
            new string[] { "はっぴょう", "でんぴょう", "", "", "", "" }, // NO FILL
            
            // Katakana
            // ア行 (A-row) - Contribution by Object777
            new string[] { "アメリカ", "アニメ", "アクセス", "アドレス", "アイスクリーム", "アパート" },
            new string[] { "インターネット", "イベント", "イメージ", "インド", "イタリアン", "イケメン" },
            new string[] { "ウール", "ウイルス", "ウーマン", "ウエスト", "ウイスキー", "ウインク" },
            new string[] { "エアコン", "エネルギー", "エコ", "エリート", "エラー", "エクセル" },
            new string[] { "オープン", "オレンジ", "オイル", "オンライン", "オーブン", "オーストラリア" },
            // カ行 (Ka-row) - Contribution by Reava_（レイ）
            new string[] { "カー", "カラー", "カロリー", "カフェ", "カレー", "カーナビ" },
            new string[] { "キッチン", "キーボード", "キス", "キッズ", "キリスト", "キーワード" },
            new string[] { "クラブ", "クーラー", "クッキー", "クール", "クレーム", "クリスマス" },
            new string[] { "ケータイ", "ケーキ", "ケース", "ケチャップ", "マーケット", "スケート" },
            new string[] { "コーヒー", "コスト", "コミック", "コンビニ", "コップ", "コミュニチー" },
            // サ行 (Sa-row) - Contribution by Reava_（レイ）
            new string[] { "サービス", "サラダ", "サイト", "サンドイッチ", "サッカー", "サングラス" },
            new string[] { "システム", "シンプル", "シート", "シリーズ", "シーズン", "シングル" },
            new string[] { "スポーツ", "スタイル", "ストップ", "スタート", "ストロベリー", "スパイス" },
            new string[] { "センター", "セールス", "センス", "セ－ター", "セミナー", "セレブ" },
            new string[] { "ソース", "ソフト", "ソング", "ソックス", "ソウル", "ソファー" },
            // タ行 (Ta-row) - Contribution by Reava_（レイ）
            new string[] { "タクシー", "タイム", "タオル", "タイ", "タワー", "タイミング" },
            new string[] { "チキン", "チーズ", "チーム", "チケット", "チップス", "チリ" },
            new string[] { "ツアー", "ツリー", "ツナ", "ツール", "シーツ", "スイーツ" },
            new string[] { "テレビ", "テーブル", "テニス", "テスト", "テーマ", "テロ" },
            new string[] { "トースト", "トマト", "トップ", "トレンド", "トータル", "トレーニング" },
            // ナ行 (Na-row) - Contribution by Reava_（レイ）
            new string[] { "ナンバ", "ナイス", "ナイト", "ナイフ", "ナプキン", "ナビゲーション" },
            new string[] { "ニーズ", "ニット", "ニート", "モニター", "スニーカー", "バニラ" },
            new string[] { "ヌードル", "ヌード", "カヌー", "セーヌ", "セザンウ", "ソルボンウ" },
            new string[] { "ネット", "ネーム", "ネクタイ", "ネック", "ネガティブ", "ネックレス" },
            new string[] { "ノート", "ノンシュガー", "ノトパソコン", "ノンストップ", "ノルウェー", "ノンアルコール" },
            // ハ行 (Ha-row) - Contribution by Reava_（レイ）
            new string[] { "ハイテク", "ハローワーク", "ハート", "ハンカチ", "ハワイ", "ハーバード" },
            new string[] { "ヒット", "ヒート", "ヒント", "ヒール", "ヒーロー", "ヒマラヤ" },
            new string[] { "フルーツ", "フリーター", "フライドポテト", "フランス", "フラッシュ", "フード" },
            new string[] { "ヘルシー", "ヘア", "ヘアスタイル", "ヘルプ", "ヘリコプター", "ヘルメット" },
            new string[] { "ホームページ", "ホテル", "ホット", "ホール", "ホリデー", "ホンコン" },
            // マ行 (Ma-row) - Contribution by Reava_（レイ）
            new string[] { "マンション", "マヨネーゼ", "マスコミ", "マナー", "マンツーマン", "マーケティング" },
            new string[] { "ミス", "ミックス", "ミーティング", "ミルク", "ミニ", "ミートボール" },
            new string[] { "ゲーム", "ムービー", "ムード", "ハム", "ドーム", "ムース" },
            new string[] { "メール", "メニュー", "メンバー", "メモリーカード", "メモ", "メンズ" },
            new string[] { "モデル", "モール", "モダン", "モノレール", "モンスター", "モンゴル" },
            // ヤ行 (Ya-row) - Contribution by Reava_（レイ）
            new string[] { "ヤング", "ヤンキー", "イヤリング", "ダイヤ", "タイヤ", "ハイヤー" },
            new string[] { "ユーザー", "ユニーク", "ユーモア", "ユーロ", "ユダヤ", "ユーゴスラビア" },
            new string[] { "ヨーロッパ", "ヨーグルト", "ヨット", "ヨーヨー", "ヨルダン", "クレヨン" },
            // ラ行 (Ra-row) - Contribution by Reava_（レイ）
            new string[] { "ランチ", "ラーメン", "ラブ", "ライト", "ランキング", "ライブ" },
            new string[] { "リサイクル", "リストラ", "リード", "リビング", "リゾート", "リーグ" },
            new string[] { "ルール", "ルポ", "ルーツ", "ルート", "スクール", "ルビール" },
            new string[] { "レストラン", "レシート", "レッスン", "レシピ", "レタス", "レーザー" },
            new string[] { "ログイン", "ロッカー", "ロボット", "ローン", "ロンドン", "ロシア" },
            // ワ行 (Wa-row) - Contribution by Reava_（レイ）
            new string[] { "ワイン", "ワールド", "ワイシャツ", "ワクチン", "ワンセグ", "ワード" },
            new string[] { "", "", "", "", "", "" }, // NO FILL
            new string[] { "カン", "リモコン", "ハンバーガー", "ベストテン", "コントロール", "コンピューター" },
            // 濁音 (Dakuon - Voiced sounds)
            // ガ行 (Ga-row) - Contribution by Reava_（レイ）
            new string[] { "ガイド", "ガス", "ガソリン", "ガラス", "ガーデニング", "ガレージ" },
            new string[] { "ギフト", "ギター", "ギリシャ", "ギア", "ギネスブック", "イゲオロギー" },
            new string[] { "グルメ", "グリーン", "グッズ", "グアム", "グランド", "マザーグース" },
            new string[] { "ゲーム", "ゲスト", "ゲーセン", "ゲート", "ゲイ", "コラーゲン" },
            new string[] { "ゴール", "ゴム", "ゴジラ", "ゴールデンウィーク", "ゴーヤ", "シカゴ" },
            // ザ行 (Za-row) - Contribution by Reava_（レイ）
            new string[] { "ピザ", "レザー", "エリザベス", "ガザ", "レーザー", "マザー" },
            new string[] { "ジーンズ", "ジム", "ジン", "デジタル", "ジミュージック", "チンパンジ" },
            new string[] { "ズボン", "ズーム", "パズル", "ローズ", "ズッキーニ", "シューズ" },
            new string[] { "ゼロ", "ゼミ", "ゼネコン", "ロゼ", "ゼラチン", "ゼッケン" },
            new string[] { "ゾーン", "アリゾナ", "アマゾン", "エキゾチック", "ゾンビ", "オゾン" },
            // ダ行 (Da-row) - Contribution by Reava_（レイ）
            new string[] { "ダンス", "ダイエット", "ダニ", "ダウンロード", "ダブル", "ダイビング" },
            new string[] { "", "", "", "", "", "" }, // NO FILL
            new string[] { "", "", "", "", "", "" }, // NO FILL
            new string[] { "データ", "デパート", "デザイン", "デート", "デザート", "デジカメ" },
            new string[] { "ドア", "ドラマ", "ドレッシング", "ドラッグストア", "ドットコム", "ハード" },
            // バ行 (Ba-row) - Contribution by Reava_（レイ）
            new string[] { "バス", "バッグ", "バー", "バナナ", "バイク", "バースデー" },
            new string[] { "ビニール", "ビジネス", "ビタミン", "ビデオ", "ビル", "ビザ" },
            new string[] { "ブランド", "ブーム", "ブロッコリ", "ブルーベリー", "ブラジャー", "ブランコ" },
            new string[] { "ベスト", "ベッド", "ベルト", "ベランダ", "ベテラン", "ベビーカー" },
            new string[] { "ボール", "ボトル", "ボート", "ボス", "ボランティア", "ボタン" },
            // パ行 (Pa-row) - Contribution by Reava_（レイ）
            new string[] { "パン", "パソコン", "パスポート", "パート", "パワーポイント", "パリ" },
            new string[] { "ピント", "ピアノ", "ピンク", "ピアス", "ピーマン", "ピッチャー" },
            new string[] { "プレゼント", "プロ", "プログラム", "プリンター", "プロフィーリ", "プライベート" },
            new string[] { "ペット", "ペン", "ページ", "ペンキ", "ペルー", "ペッパー" },
            new string[] { "ポイント", "ポスト", "ポスター", "ポケット", "ポット", "ポップ" },
            // 拗音 (Youon - Contracted sounds)
            // キャ行 (Kya-row) - Contribution by Reava_（レイ）
            new string[] { "キャリア", "キャベツ", "キャラクター", "キャッシング", "キャプテン", "キャッチャー" },
            new string[] { "バーベキュ", "セキュリティー", "キューバ", "キュート", "サンキュー", "レスキュー" },
            new string[] { "", "", "", "", "", "" }, // NO FILL
            // シャ行 (Sha-row) - Contribution by Reava_（レイ）
            new string[] { "シャツ", "シャンプー", "シャワー", "シャンパン", "シャイ", "ミュージシャン" },
            new string[] { "シュガー", "シュクリーム", "シュート", "プッシュ", "シュウマイ", "マッシュルーム" },
            new string[] { "シェフ", "シェーク", "シェア", "シェーバー", "シェークスピア", "シェリー" },
            new string[] { "ショップ", "ショー", "ショッピング", "ショック", "ショルダーバッグ", "クッション" },
            // チャ行 (Cha-row) - Contribution by Reava_（レイ）
            new string[] { "チャンメル", "チャンス", "チャンプオン", "チャペル", "チャイルド", "チャーミング" },
            new string[] { "チューリップ", "チューインガム", "チューナー", "チューブ", "シチュ", "スチューデント" },
            new string[] { "チェックイン", "チェーン", "チェリー", "チェンジ", "チェス", "チェック" },
            new string[] { "チョコレート", "チョイス", "チョーク", "クエスチョン", "チョップ", "ランチョンマット" },
            // ニャ行 (Nya-row) - Contribution by Reava_（レイ）
            new string[] { "コニャック", "ニャンコ", "コンヤク", "カタルーニャ", "ボローニャ", "バーニャカウダ" },
            new string[] { "ニュース", "ニューヨーク", "ニュー", "ニュータウン", "ニュージーランド", "ニュアンス" },
            new string[] { "エルニーニョ", "ニョッキ", "シャンピニョン", "ハラペーニョ", "アビニョン", "ニョクマム" },
            // ヒャ行 (Hya-row) - Contribution by Reava_（レイ）
            new string[] { "", "", "", "", "", "" }, // NO FILL
            new string[] { "ヒューマン", "ヒューズ", "ヒューマニズム", "ペヒューム", "ヒューストン", "ヒューロン" },
            new string[] { "", "", "", "", "", "" }, // NO FILL
            // ミャ行 (Mya-row) - Contribution by Reava_（レイ）
            new string[] { "ミャンマー", "", "", "", "", "" },// Partial
            new string[] { "ミュージアム", "ミュージカル", "ミュンヘン", "バミュダ", "サミュエル", "アミューズメント" },
            new string[] { "", "", "", "", "", "" }, // NO FILL
            // リャ行 (Rya-row) - Contribution by Reava_（レイ）
            new string[] { "カスティーリャ", "コーリャｎ", "パエーリャ", "", "", "" }, 　// Partial
            new string[] { "リュック", "リューマチ", "レボリューション", "ボリューム", "ソリューション", "スクリュー" },
            new string[] { "マトリョーシカ", "", "", "", "", "" }, 　// Partial
            // ギャ行 (Gya-row) - Contribution by Reava_（レイ）
            new string[] { "ギャル", "ギャンブル", "ギャグ", "ギャング", "ギャラリ", "ギャラ" },
            new string[] { "レギュラー", "フィギュア", "フィギュアスケート", "イレギュラー", "レギュレータ", "" }, // Partial
            new string[] { "ギョーザ", "", "", "", "", "" }, 　// Partial
            // ジャ行 (Ja-row) - Contribution by Reava_（レイ）
            new string[] { "ジャム", "ジャケット", "ジャズ", "ジャンル", "ジャーナル", "ジャンプ" },
            new string[] { "ジュニア", "ジュース", "ジュエリー", "ジュネーブ", "コラージュ", "ルージュ" },
            new string[] { "ジェット", "ジェリー", "ジェラシー", "ジェスチャー", "オブジェ", "ジェムス" },
            new string[] { "ジョーク", "ジョギング", "ジョッキ", "", "", "" }, 　// Partial
            // ビャ行 (Bya-row) - Contribution by Reava_（レイ）
            new string[] { "", "", "", "", "", "" }, // NO FILL
            new string[] { "ビューティー", "インタビュー", "ビュッフェ", "ビューラー", "レビュー", "デビュー" },
            new string[] { "", "", "", "", "", "" }, // NO FILL
            // ピャ行 (Pya-row) - Contribution by Reava_（レイ）
            new string[] { "", "", "", "", "", "" }, // NO FILL
            new string[] { "ポピュラー", "ピュア", "ピューマ", "ピュリッツアー", "ピューレ", "" }, 　// Partial
            new string[] { "ピョンヤン", "ピョートル", "", "", "", "" }, // Partial
            // 外来音 (Gairaigo - Loan/foreign sounds)
            // ティ・トゥ行 (Ti/Tu-row) - Contribution by Reava_（レイ）
            new string[] { "ティー", "パーティー", "ティッシュ", "アイデンティティー", "パティシエ", "バラエティ" },
            new string[] { "テューバ", "インスティテュート", "テュイション", "", "", "" }, 　// Partial
            // ディ・ドゥ行 (Di/Du-row) - Contribution by Reava_（レイ）
            new string[] { "ディナー", "ディープ", "メロディー", "パロディー", "ディレクター", "ディスク" },
            new string[] { "ドゥアル", "エドゥケーション", "フォンドゥ", "ドゥエット", "プロドゥーサー", "ドゥオ" },
            // ファ行 (Fa-row)
            new string[] { "ファミリー", "ファッション", "ファックス", "ファイト", "", "" }, // Partial
            new string[] { "フィッシュ", "フィリム", "フィト", "フィクション", "", "" }, // Partial
            new string[] { "", "", "", "", "", "" }, // NO FILL
            new string[] { "マニフェスト", "フェミニン", "フェンス", "フェアプレー", "", "" }, // Partial
            new string[] { "フォーク", "フォーム", "フォーラム", "フォアグラ", "", "" }, // Partial
            // ツァ行 (Tsa-row)
            new string[] { "", "", "", "", "", "" }, // NO FILL
            new string[] { "", "", "", "", "", "" }, // NO FILL
            new string[] { "", "", "", "", "", "" }, // NO FILL
            // ウィ行 (Wi-row) - Contribution by Reava_（レイ）
            new string[] { "ウィーク", "ウィンドー", "ウィッグ", "ウィンアー", "サンドウィッチ", "ハロウィン" },
            new string[] { "ウェルカム", "クウェート", "ウェヂング", "ウェンズデー", "", "" }, // Partial
            new string[] { "ウォーキング", "ウォールストリート", "ウォームアップ", "ウォーター", "", "" },　// Partial
            // ヴァ行 (Va-row) - Contribution by Reava_（レイ）
            new string[] { "ヴァイオリン", "ヴァリエーション", "ヴァージン", "ヴァイオレット", "ヴィヴァリディ", "ヴァケーション" },
            new string[] { "", "", "", "", "", "" }, // NO FILL
            new string[] { "", "", "", "", "", "" }, // NO FILL
            new string[] { "", "", "", "", "", "" }, // NO FILL
            new string[] { "", "", "", "", "", "" } // NO FILL
        };

        private readonly string[][] KanaWordsRomaji = new string[][] {
            // Hiragana
            // あ行 (A-row) - Contribution by Object777
            new string[] { "are", "asoko", "ashita", "arimasu", "aisatsu", "arigatou" },
            new string[] { "iie", "itsu", "inu", "iru", "ichigo", "itadakimasu" },
            new string[] { "uchi", "ushiro", "ue", "udon", "urusai", "ureshii" },
            new string[] { "ee", "eki", "ebi", "eigo", "enpitsu", "en" },
            new string[] { "ohayou", "otona", "oishii", "owari", "omoshiroi", "omocha" },
            // か行 (Ka-row) - Contribution by Object777
            new string[] { "kasa", "kaban", "kao", "kawaii", "kakeru", "shikashi" },
            new string[] { "kinou", "kirei", "kimono", "kimi", "kippu", "kirai" },
            new string[] { "kudasai", "kuruma", "kutsu", "kusuri", "ikura", "kurikaesu" },
            new string[] { "keru", "kega", "kenka", "keredo", "kekkon", "kejime" },
            new string[] { "kotoba", "kochira", "kodomo", "kome", "kotatsu", "koshou" },
            // さ行 (Sa-row) - Contribution by Object777
            new string[] { "sayonara", "sumisu san", "sashimi", "satou", "sabishii", "sawayaka" },
            new string[] { "shimasu", "shimashita", "shimau", "shio", "shikkari", "shikaru" },
            new string[] { "suru", "sushi", "sumimasen", "sugu", "suki", "sugoi" },
            new string[] { "shimasen", "sensei", "sentaku", "semai", "sekkaku", "aseru" },
            new string[] { "sore", "soko", "soudesu", "soba", "souji", "sorosoro" },
            // た行 (Ta-row) - Contribution by Nerazawa
            new string[] { "taberu", "tatami", "takusan", "tada", "tamago", "tanoshii" },
            new string[] { "chichi", "chigau", "chika", "chiisai", "chikai", "kocchi" },
            new string[] { "tsugi", "tsuzuku", "tsukemono", "tsuyoi", "tsumaranai", "tsumori" },
            new string[] { "te", "tegami", "tenki", "tenpura", "tetsudau", "tebukuro" },
            new string[] { "tori", "tomodachi", "tokei", "totemo", "toufu", "koretosore" },
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
            new string[] { "heya", "heta", "heru", "Kochira e douzo.", "Dochira e?", "minasan e" },
            new string[] { "hontou", "hoshii", "hotondo", "houki", "hokori", "hourensou" },
            // ま行 (Ma-row) - Contribution by Soup
            new string[] { "mae", "mada", "massugu", "mane", "makura", "majime" },
            new string[] { "midori", "mikan", "minasan", "migi", "mimi", "misoshiru" },
            new string[] { "muri", "musume", "(o)musubi", "mukou", "muzukashii", "mushiatsui" },
            new string[] { "me", "meshi", "men", "megane", "mendou", "omedetou" },
            new string[] { "mono", "mou", "moshi", "morau", "motto", "moteru" },
            // や行 (Ya-row) - Contribution by Soup
            new string[] { "yaru", "yasashii", "yakitori", "yasumi", "yameru", "yakamashii" },
            new string[] { "yu", "yuki", "yume", "yuubin", "yukkuri", "yuzu" },
            new string[] { "yoku", "yoko", "yomu", "yoru", "yoroshiku", "yokatta" },
            // ら行 (Ra-row) - Contribution by JustJaime
            new string[] { "achira", "sakura", "irasshaimase", "rashii", "raku", "rainen" },
            new string[] { "ringo", "rippa", "irimasu", "rikai", "rikon", "riyuu" },
            new string[] { "rusu", "rusuban", "rusuchuu", "maru", "ruijiten", "dourui" },
            new string[] { "kore", "rei", "renshuu", "rekishi", "renraku", "renkon" },
            new string[] { "roku", "rouka", "roujin", "kuro", "shiro", "mushiro" },
            // わ行 (Wa-row) - Contribution by JustJaime
            new string[] { "watashi", "wakaru", "wareru", "wake", "wasabi", "wagamama" },
            new string[] { "Kore o kudasai.", "Sushi o tabeta.", "Souji o shita", "Megane o kaketa.", "Aisatsu o shita.", "Koko o katazukeyou." },
            new string[] { "minna", "un", "Konnichiwa.", "onna", "zenzen", "manga" },
            // 濁音 (Dakuon - Voiced sounds)
            // が行 (Ga-row) - Contribution by Soup
            new string[] { "kore ga ii.", "sumimasen ga", "ganbaru", "gaijin", "gakkari suru", "gaman suru" },
            new string[] { "ginkou", "kagi", "onigiri", "giri", "girigiri", "kagiru" },
            new string[] { "guai", "guchi", "guzuguzu", "naguru", "guuzen", "gurai" },
            new string[] { "genki", "genkan", "geri", "getsumatsu", "gengo", "genin" },
            new string[] { "gohan", "gomi", "gochisousama", "gozaimasu", "goma", "goro" },
            // ざ行 (Za-row) - Contribution by Soup
            new string[] { "zabuton", "zannen", "zasshi", "zaru", "zashiki", "uzai" },
            new string[] { "jikan", "jibun", "jiko", "jishin", "jitensha", "jikochuu" },
            new string[] { "zurui", "zuibun", "zutto", "zureru", "zurasu", "zubon" },
            new string[] { "zenbu", "kaze", "mazeru", "zehi", "zettai", "zentai" },
            new string[] { "douzo", "zou", "gozonji desu", "zouri", "zokusuru", "zokuzoku" },
            // だ行 (Da-row) - Contribution by Soup
            new string[] { "dame", "dakara", "dandan", "daijoubu", "daigaku", "dake" },
            new string[] { "chijimu", "chijireru", "hanaji", "tejika", "chikajika", "warukie" },
            new string[] { "katazukeru", "tsuzukeru", "tsuzuku", "tsuzuri", "kanzume", "kizuku" },
            new string[] { "denwa", "dekiru", "denki", "dekakeru", "desu", "detarame" },
            new string[] { "dore", "doumo", "doji", "doko", "doushite", "dorobou" },
            // ば行 (Ba-row) - Contribution by Soup
            new string[] { "baka", "banzai", "bara", "bareru", "barabara", "bakari" },
            new string[] { "bin", "bikkurisuru", "bisshori", "bimyou", "bibiru", "binbou" },
            new string[] { "abunai", "budou", "buta", "bukka", "bunka", "bushitsuke" },
            new string[] { "benkyou", "bentou", "betsu", "betsubetsu", "benri", "bengoshi" },
            new string[] { "boku", "boushi", "boroboro", "bocchan", "bou", "boueki" },
            // ぱ行 (Pa-row) - Contribution by JustJaime
            new string[] { "pachipachi", "parapara", "patto", "suppai", "sappari", "tsupparu" },
            new string[] { "pikapika", "choppiri", "pittari", "pirikara", "heppirigoshi", "dadappiroi" },
            new string[] { "juppun", "senpuuki", "uppun", "manpuku", "shiranpuri", "ninpu" },
            new string[] { "perapera", "pekopeko", "pechanko", "pechakucha", "teppen", "ippen" },
            new string[] { "Nippon", "sanpo", "ponzu", "shippo", "kodomoppoi", "ippoutsuukou" },
            // 拗音 (Youon - Contracted sounds)
            // きゃ行 (Kya-row) - Contribution by Nerazawa
            new string[] { "kyaku", "okyaku san", "kyakushitsu", "shoukyaku", "shikkyaku", "kyakkanteki" },
            new string[] { "kyuu", "kyuukei", "kenkyuu", "kyuukyuusha", "kyuuri", "kyuushoku" },
            new string[] { "kyou", "kyonen", "kyoushitsu", "senkyo", "kyori", "kyoumi" },
            // しゃ行 (Sha-row) - Contribution by nerazawa
            new string[] { "shashin", "shaberu", "shakai", "shain", "shabushabu", "isha" },
            new string[] { "shumi", "shukudai", "shujin", "shurui", "shuu", "shucchou" },
            new string[] { "shouyu", "shoukai", "shou ga nai", "deshou", "shimashou", "shougakkou" },
            // ちゃ行 (Cha-row) - Contribution by Object777
            new string[] { "ocha", "[name]-chan", "chanto", "mechakucha", "chawan", "chapatsu" },
            new string[] { "chuui", "chuugoku", "chuugakkou", "chuushoku", "hanashichuu", "chuukaryouri" },
            new string[] { "chotto", "choudo", "chokusetsu", "chokin", "shachou", "chou" },
            // にゃ行 (Nya-row) - Contribution by Object777
            new string[] { "nyanko", "gunyagunya", "konnyaku", "nyānyā", "rounyakunannyo", "funyafunya" },
            new string[] { "nyuuryoku", "nyuugaku", "nyuukai", "nyuuin", "kinyuu suru", "honyuurui" },
            new string[] { "nyou", "nyoukensa", "nyoubou", "nyouboumochi", "nyokinyoki", "nyoronyoro" },
            // ひゃ行 (Hya-row) - Contribution by Soup
            new string[] { "hyaku", "hyakusai", "hyakunen", "nihyakuen", "hyakkaten", "hyakkajiten" },
            new string[] { "hyuuhyuu", "", "", "", "", "" },
            new string[] { "hyouka", "hyouban", "hyou", "yoteihyou", "hyoukin", "hyorohyoro" },
            // みゃ行 (Mya-row) - Contribution by Soup/Yuka ゆか
            new string[] { "mayku", "jinmyaku", "sanmyaku", "myakumyaku", "bunmyaku", "doumyaku" },
            new string[] { "myuujin", "myuugaku", "", "", "", "" },
            new string[] { "myounichi", "myouchou", "myougonichi", "myouji", "myou", "jumyou" },
            // りゃ行 (Rya-row) - Contribution by Soup/Yuka ゆか
            new string[] { "ryaku", "ryakugo", "ryakuji", "ryakureki", "shouryaku", "zenryaku" },
            new string[] { "ryuugaku", "ryuugakusei", "ryuuko", "shuryuu", "jikoryuu", "nihonryuu" },
            new string[] { "ryokou", "ryouri", "ryoushin", "ryokan", "shiryou", "ryou" },
            // ぎゃ行 (Gya-row) - Contribution by Soup/Yuka ゆか
            new string[] { "gyaku", "gyakutai", "gyakusetsu", "gyakuten", "gyakkou", "gyakkyou" },
            new string[] { "gyuunyuu", "gyuuniku", "gyuugyuu", "gyutto", "gyuudon", "gyuujiru" },
            new string[] { "gyougi", "gyouji", "gyou", "gyoukai", "gyogyou", "kingyo" },
            // じゃ行 (Ja-row) - Contribution by Soup/Yuka ゆか
            new string[] { "jā", "jama", "jā mata", "ja nai", "janken", "janjan" },
            new string[] { "jugyou", "jyuusho", "juu", "junban", "juuyou", "kyouju" },
            new string[] { "jouzu", "josei", "joudan", "joshu", "joyuu", "jojo ni" },
            // ぢゃ行 (Dja-row) - Contribution by Soup/Yuka ゆか
            new string[] { "yunomi-jawan", "sumou-jaya", "jaguchi", "jama", "jari", "janpu" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // びゃ行 (Bya-row) - Contribution by Soup/Yuka ゆか
            new string[] { "sanbyaku", "nan byaku en", "", "", "", "" },
            new string[] { "byuubyuu", "", "", "", "", "" },
            new string[] { "byouki", "byouin", "", "", "", "" },
            // ぴゃ行 (Pya-row) - Contribution by Soup/Yuka ゆか
            new string[] { "roppyaku", "happyaku", "uso-happyaku", "", "", "" },
            new string[] { "pyuupyuu", "", "", "", "", "" },
            new string[] { "happyou", "denpyou", "", "", "", "" },
            
            // Katakana
            // ア行 (A-row) - Contribution by Object777
            new string[] { "amerika", "anime", "akusesu", "adoresu", "aisukurīmu", "apāto" },
            new string[] { "intānetto", "ibento", "imēji", "indo", "itarian", "ikemen" },
            new string[] { "uuru", "uirusu", "uuman", "uesuto", "uisukī", "uinku" },
            new string[] { "eakon", "enerugī", "eko", "erīto", "erā", "ekuseru" },
            new string[] { "oupun", "orenji", "oiru", "onrain", "oubun", "ousutoraria" },
            // カ行 (Ka-row) - Contribution by Object777
            new string[] { "kādo", "karā", "karorī", "kafe", "karē", "kānabi" },
            new string[] { "kicchin", "kīboudo", "kisu", "kizzu", "kirisuto", "kīwādo" },
            new string[] { "kurabu", "kuurā", "kukkī", "kuuru", "kurēmu", "kurisumasu" },
            new string[] { "kētai", "kēki", "kēsu", "kechappu", "māketto", "sukēto" },
            new string[] { "kouhī", "kosuto", "komikku", "konbini", "koppu", "komyunitī" },
            // サ行 (Sa-row) - Contribution by Object777
            new string[] { "sābisu", "sarada", "saito", "sandoicchi", "sakkā", "sangurasu" },
            new string[] { "shisutemu", "shinpuru", "shīto", "shirīzu", "shīzun", "shinguru" },
            new string[] { "supoutsu", "sutairu", "sutoppu", "sutāto", "sutoroberī", "supaisu" },
            new string[] { "sentā", "sērusu", "sensu", "sētā", "seminā", "serebu" },
            new string[] { "sousu", "sofuto", "songu", "sokkusu", "souru", "sofā" },
            // タ行 (Ta-row) - Contribution by Object777
            new string[] { "takushī", "taimu", "taoru", "tai", "tawā", "taimingu" },
            new string[] { "chikin", "chīzu", "chīmu", "chiketto", "chippusu", "chiri" },
            new string[] { "tsuā", "tsurī", "tsuna", "tsuuru", "shītsu", "swītsu" },
            new string[] { "terebi", "tēburu", "tenisu", "tesuto", "tēma", "tero" },
            new string[] { "tousuto", "tomato", "toppu", "torendo", "toutaru", "torēningu" },
            // ナ行 (Na-row) - Contribution by Object777
            new string[] { "nanbā", "naisu", "naito", "naifu", "napukin", "nabigēshon" },
            new string[] { "nīzu", "nitto", "nīto", "monitā", "sunīkā", "banira" },
            new string[] { "nuudoru", "nuudo", "kanuu", "sēnu", "sezannu", "sorubonnu" },
            new string[] { "netto", "nēmu", "nekutai", "nekku", "negatibu", "nekkuresu" },
            new string[] { "nouto", "nonshugā", "noutopasokon", "non-sutoppu", "noruwē", "non-arukouru" },
            // ハ行 (Ha-row) - Contribution by Object777
            new string[] { "haiteku", "harou wāku", "hāto", "hankachi", "hawai", "hābādo" },
            new string[] { "hitto", "hīto", "hinto", "hīru", "hīrou", "himaraya" },
            new string[] { "furuutsu", "furītā", "furaido poteto", "furansu", "furasshu", "fuudo" },
            new string[] { "herushi", "hea", "heasutairu", "herupu", "herikoputā", "herumetto" },
            new string[] { "houmupēji", "hoteru", "hotto", "houru", "horidē", "honkon" },
            // マ行 (Ma-row) - Contribution by Object777
            new string[] { "manshon", "mayonēze", "masukomi", "manā", "mantsuuman", "māketingu" },
            new string[] { "misu", "mikkusu", "mītingu", "miruku", "mini", "mītobouru" },
            new string[] { "gēmu", "muubī", "muudo", "hamu", "doumu", "muusu" },
            new string[] { "mēru", "menyuu", "menbā", "memori kādo", "memo", "menzu" },
            new string[] { "moderu", "mouru", "modan", "monorēru", "monsutā", "mongoru" },
            // ヤ行 (Ya-row) - Contribution by Object777
            new string[] { "yangu", "yankī", "iyaringu", "daiya", "taiya", "haiyā" },
            new string[] { "yuuzā", "yunīnu", "yuumoa", "yuuro", "yudaya", "yuugosurabia" },
            new string[] { "youroppa", "youguruto", "yotto", "youyou", "yorudan", "kureyon" },
            // ラ行 (Ra-row) - Contribution by Object777
            new string[] { "ranchi", "rāmen", "rabu", "raito", "rankingu", "raibu" },
            new string[] { "risaikuru", "risutora", "rīdo", "ribingu", "rizouto", "rīgu" },
            new string[] { "ruuru", "rupo", "ruutsu", "ruuto", "sukuuru", "bīru" },
            new string[] { "resutoran", "reshīto", "ressun", "reshipi", "retasu", "rēzā" },
            new string[] { "roguin", "rokkā", "robotto", "roun", "rondon", "roshia" },
            // ワ行 (Wa-row) - Contribution by Object777
            new string[] { "wain", "wārudo", "waishatsu", "wakuchin", "wansegu", "wādo" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "kan", "rimokon", "hanbāgā", "besuto ten", "kontorouru", "konpyuutā" },
            // 濁音 (Dakuon - Voiced sounds)
            // ガ行 (Ga-row) - Contribution by Object777
            new string[] { "gaido", "gasu", "gasorin", "garasu", "gādeningu", "garēji" },
            new string[] { "gifuto", "gitā", "girisha", "gia", "ginesubukku", "ideorogī" },
            new string[] { "gurume", "gurīn", "guzzu", "guamu", "gurando", "mazāguusu" },
            new string[] { "gēmu", "gesuto", "gēsen", "gēto", "gei", "korāgen" },
            new string[] { "gouru", "gomu", "gojira", "gouruden wiku", "gouya", "shikago" },
            // ザ行 (Za-row) - Contribution by Object777
            new string[] { "piza", "rezā", "erizabesu", "gaza", "rēzā", "mazā" },
            new string[] { "jīnzu", "jimu", "jin", "dejitaru", "myuujikku", "chinpanjī" },
            new string[] { "zubon", "zuumu", "pazuru", "rouzu", "zukkīni", "shuuzu" },
            new string[] { "zero", "zemi", "zenekon", "roze", "zerachin", "zekken" },
            new string[] { "zoun", "arizon", "amazon", "ekizochikku", "zonbi", "ozon" },
            // ダ行 (Da-row) - Contribution by Object777
            new string[] { "dansu", "daietto", "dani", "daunroudo", "daburu", "daibingu" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "dēta", "depāto", "dezain", "dēto", "dezāto", "dejikame" },
            new string[] { "doa", "dorama", "doresshingu", "doraggu sutoa", "dottokomu", "hādo" },
            // バ行 (Ba-row) - Contribution by Object777
            new string[] { "basu", "baggu", "bā", "banana", "baiku", "bāsudē" },
            new string[] { "binīru", "bijinesu", "bitamin", "bideo", "biru", "biza" },
            new string[] { "burando", "buumu", "burokkori", "buruuberī", "burajā", "buranko" },
            new string[] { "besuto", "beddo", "beruto", "beranda", "beteran", "bebīkā" },
            new string[] { "bouru", "botoru", "boutu", "bosu", "borantia", "botan" },
            // パ行 (Pa-row) - Contribution by Object777
            new string[] { "pan", "pasokon", "pasupouto", "pāto", "pawāpointo", "pari" },
            new string[] { "pinto", "piano", "pinku", "piasu", "pīman", "pittyā" },
            new string[] { "purezento", "puro", "puroguramu", "purintā", "purofīru", "puraibēto" },
            new string[] { "petto", "pen", "pēji", "penki", "peruu", "peppā" },
            new string[] { "pointo", "posuto", "posutā", "pokketo", "potto", "poppu" },
            // 拗音 (Youon - Contracted sounds)
            // キャ行 (Kya-row) - Contribution by Object777
            new string[] { "kyaria", "kyabetsu", "kyarakutā", "kyasshingu", "kyaputen", "kyacchā" },
            new string[] { "bābekyuu", "sekyuritī", "kyuuba", "kyuuto", "sankyuu", "resukyuu" },
            new string[] { "", "", "", "", "", "" },
            // シャ行 (Sha-row) - Contribution by Object777
            new string[] { "shatsu", "shanpuu", "shawā", "shanpan", "shai", "myuujishan" },
            new string[] { "shugā", "shuukurīmu", "shuuto", "pusshu", "shuumai", "masshuruumu" },
            new string[] { "shefu", "shēku", "shea", "shēbā", "shēkusupia", "sherī" },
            new string[] { "shoppu", "shou", "shoppingu", "shokku", "shorudābaggu", "kusshon" },
            // チャ行 (Cha-row) - Contribution by Object777
            new string[] { "channeru", "chansu", "chanpion", "chaperu", "chairudo", "chāmingu" },
            new string[] { "chuurippu", "chuuingamu", "chuunā", "chuubu", "shichuu", "suchuudento" },
            new string[] { "chekku-in", "chēn", "cherī", "chenji", "chesu", "chekku" },
            new string[] { "chokorēto", "choisu", "chouku", "kuesuchon", "choppu", "ranchon-matto" },
            // ニャ行 (Nya-row) - Contribution by Object777
            new string[] { "konyakku", "nyanko", "konnyaku", "kataruunya", "borounya", "bānya-kauda" },
            new string[] { "nyuusu", "nyuuyouku", "nyuu", "nyuutaun", "nyuujīrando", "nyuansu" },
            new string[] { "erunīnyo", "nyokki", "shanpinyon", "harapēnyo", "abinyon", "nyokumamu" },
            // ヒャ行 (Hya-row) - Contribution by Object777
            new string[] { "", "", "", "", "", "" },
            new string[] { "hyuuman", "hyuuzu", "hyuumanizumu", "pehyuumu", "hyuusuton", "hyuuron" },
            new string[] { "", "", "", "", "", "" },
            // ミャ行 (Mya-row) - Contribution by Object777
            new string[] { "myanmā", "", "", "", "", "" },
            new string[] { "myuujiamu", "myuujikaru", "myunhen", "bamyuuda", "samyueru", "amyuuzumento" },
            new string[] { "", "", "", "", "", "" },
            // リャ行 (Rya-row) - Contribution by Object777
            new string[] { "kasutīrya", "kouryan", "paērya", "", "", "" },
            new string[] { "ryukku", "ryuumachi", "reboryuushon", "boryuumu", "soryuushon", "sukuryuu" },
            new string[] { "matoryoushika", "", "", "", "", "" },
            // ギャ行 (Gya-row) - Contribution by Object777
            new string[] { "gyaru", "gyanburu", "gyagu", "gyangu", "gyararī", "gyara" },
            new string[] { "regyurā", "figyua", "figyua-skēto", "iregyurā", "regyurēta", "" },
            new string[] { "gyouza", "", "", "", "", "" },
            // ジャ行 (Ja-row) - Contribution by Object777
            new string[] { "jamu", "jaketto", "jazu", "janru", "jānaru", "janpu" },
            new string[] { "junia", "juusu", "juerī", "junēbu", "korāju", "ruuju" },
            new string[] { "jetto", "jerī", "jerashī", "jesuchā", "obuje", "jēmusu" },
            new string[] { "jouku", "jogingu", "jokki", "", "", "" },
            // ビャ行 (Bya-row) - Contribution by Object777
            new string[] { "", "", "", "", "", "" },
            new string[] { "byuutī", "intabyuu", "byuffe", "byuurā", "rebyuu", "debyuu" },
            new string[] { "", "", "", "", "", "" },
            // ピャ行 (Pya-row) - Contribution by Object777
            new string[] { "", "", "", "", "", "" },
            new string[] { "popyurā", "pyua", "pyuuma", "pyurittsā", "pyuure", "" },
            new string[] { "pyonyan", "pyoutoru", "", "", "", "" },
            // 外来音 (Gairaigo - Loan/foreign sounds)
            // ティ・トゥ行 (Ti/Tu-row) - Contribution by Object777
            new string[] { "tī", "pātī", "tisshu", "taidentitī", "patishie", "baraetī" },
            new string[] { "tuuba", "insutituuto", "tuishon", "", "", "" },
            // ディ・ドゥ行 (Di/Du-row) - Contribution by Object777
            new string[] { "dinā", "dīpu", "merodī", "parodī", "direkutā", "disuku" },
            new string[] { "duaru", "edukēshon", "fondu", "duetto", "puroduusā", "duo" },
            // ファ行 (Fa-row) - Contribution by Object777
            new string[] { "famirī", "fasshon", "fakkusu", "faito", "", "" },
            new string[] { "fisshu", "firumu", "fīto", "fikushon", "", "" },
            new string[] { "manifesuto", "feminin", "fensu", "fea purē", "", "" },
            new string[] { "fouku", "foumu", "fouramu", "foagura", "", "" },
            new string[] { "", "", "", "", "", "" },
            // ツァ行 (Tsa-row) - Contribution by Object777
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // ウィ行 (Wi-row) - Contribution by Object777
            new string[] { "wīku", "windou", "wiggu", "winnā", "sandowicchi", "harowīn" },
            new string[] { "werukamu", "kuwēto", "wedingu", "wenzudē", "", "" },
            new string[] { "woukingu", "wourusutorīto", "woumuappu", "woutā", "", "" },
            // ヴァ行 (Va-row) - Contribution by Object777
            new string[] { "vaiorin", "variēshon", "vājin", "vaioretto", "vivarudi", "vakēshon" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
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
            new string[] { "bird; chicken", "friend", "clock; watch", "very; extremely", "toufu", "this thing and that thing near you" },
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
            new string[] { "whistling sound; sound of wind", "", "", "", "", "" },
            new string[] { "evaluation; assess", "reputation; fame; popularity", "chart", "schedule, itinerary", "facetious, funny", "frail; lanky" },
            // みゃ行 (Mya-row) - Contribution by Soup/Yuka ゆか & Reava_
            new string[] { "pulse", "personal connection", "mountain range", "continuous, unbroken", "context", "[medical term] artery" },
            new string[] { "civilian (non-military person)", "music theory", "", "", "", "" },
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
            new string[] { "(japanese) tea cup", "ticket agent for sumou", "faucet, tap", "hindrance, nuisance", "gravel", "jump" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            // びゃ行 (Bya-row) - Contribution by Soup/Yuka ゆか
            new string[] { "three hundred", "how many hundred yen", "", "", "", "" },
            new string[] { "Howl (sound of wind)", "", "", "", "", "" },
            new string[] { "sick; sickness", "hospital", "", "", "", "" },
            // ぴゃ行 (Pya-row) - Contribution by Soup/Yuka ゆか
            new string[] { "six hundred", "eight hundred", "all sorts of lies; tissue of lies", "", "", "" },
            new string[] { "sound of whistling", "", "", "", "", "" },
            new string[] { "announcement, presentation", "sales slip, voucher", "", "", "", "" },
    
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
            new string[] { "can", "remote control", "hamburger", "best ten", "control", "computer" },
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
            new string[] { "", "", "", "", "", "" },
            new string[] { "", "", "", "", "", "" },
            new string[] { "data", "department store", "design", "date", "dessert", "digital camera" },
            new string[] { "door", "drama", "(salad) dressing", "drug store", "dotcom", "hard" },
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
