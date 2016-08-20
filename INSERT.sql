INSERT INTO `lecciodivina`.`lexicon` (`lexiconID`, `lexiconName`) VALUES ('1', '---');
INSERT INTO `lecciodivina`.`lexicon` (`lexiconID`, `lexiconName`) VALUES ('2', 'American');
INSERT INTO `lecciodivina`.`lexicon` (`lexiconID`, `lexiconName`) VALUES ('3', 'Spanish');
INSERT INTO `lecciodivina`.`lexicon` (`lexiconID`, `lexiconName`) VALUES ('4', 'Latin');

/* --------------------------------------------------------------------------------------- */

INSERT INTO `lecciodivina`.`bible` (`bibleID`, `bibleName`, `bibleDescription`, `lexicon_FK`) VALUES ('1', '---', '---', '1');
INSERT INTO `lecciodivina`.`bible` (`bibleID`, `bibleName`, `bibleDescription`, `lexicon_FK`) VALUES ('2', 'New American Bible', 'American Catholic Bible', '2');
INSERT INTO `lecciodivina`.`bible` (`bibleID`, `bibleName`, `bibleDescription`, `lexicon_FK`) VALUES ('3', 'King James Bible', 'Protestant Bible', '2');

/* --------------------------------------------------------------------------------------- */

INSERT INTO `lecciodivina`.`book` (`bookID`, `bookName`, `bookNumber`, `bookDescription`, `bible_FK`, `lexicon_FK`) VALUES ('1', '---', '0', '---', '1', '1');
INSERT INTO `lecciodivina`.`book` (`bookID`, `bookName`, `bookNumber`, `bookDescription`, `bible_FK`, `lexicon_FK`) VALUES ('2', 'Pslams', '23', 'The Hebrew Psalter numbers 150 songs', '1', '2');
INSERT INTO `lecciodivina`.`book` (`bookID`, `bookName`, `bookNumber`, `bookDescription`, `bible_FK`, `lexicon_FK`) VALUES ('3', 'Matthew', '47', 'THE GOSPEL ACCORDING TO MATTHEW', '1', '2');
INSERT INTO `lecciodivina`.`book` (`bookID`, `bookName`, `bookNumber`, `bookDescription`, `bible_FK`, `lexicon_FK`) VALUES ('4', 'Mark', '48', 'THE GOSPEL ACCORDING TO MARK', '1', '2');
INSERT INTO `lecciodivina`.`book` (`bookID`, `bookName`, `bookNumber`, `bookDescription`, `bible_FK`, `lexicon_FK`) VALUES ('5', 'Luke', '49', 'THE GOSPEL ACCORDING TO LUKE', '1', '2');
INSERT INTO `lecciodivina`.`book` (`bookID`, `bookName`, `bookNumber`, `bookDescription`, `bible_FK`, `lexicon_FK`) VALUES ('6', 'John', '50', 'THE GOSPEL ACCORDING TO JOHN', '1', '2');

/* --------------------------------------------------------------------------------------- */

INSERT INTO `lecciodivina`.`chapter` (`chapterID`, `chapterName`, `chapterNumber`, `chapterDescription`, `book_FK`) VALUES ('1', ' ', '0', '---', '1');
INSERT INTO `lecciodivina`.`chapter` (`chapterID`, `chapterName`, `chapterNumber`, `chapterDescription`, `book_FK`) VALUES ('2', 'Matthew Chapter 1', '1', 'The Genealogy of Jesus', '3');
INSERT INTO `lecciodivina`.`chapter` (`chapterID`, `chapterName`, `chapterNumber`, `chapterDescription`, `book_FK`) VALUES ('3', 'Luke Chapter 1', '1', 'Announcement of the Birth of John', '5');
INSERT INTO `lecciodivina`.`chapter` (`chapterID`, `chapterName`, `chapterNumber`, `chapterDescription`, `book_FK`) VALUES ('4', 'Luke Chapter 2', '2', 'The Birth of Jesus', '5');
INSERT INTO `lecciodivina`.`chapter` (`chapterID`, `chapterName`, `chapterNumber`, `chapterDescription`, `book_FK`) VALUES ('5', 'John Chapter 1', '1', 'In the beginning', '6');
INSERT INTO `lecciodivina`.`chapter` (`chapterID`, `chapterName`, `chapterNumber`, `chapterDescription`, `book_FK`) VALUES ('6', 'Psalm 1', '1', 'Blessed is the man', '2');
INSERT INTO `lecciodivina`.`chapter` (`chapterID`, `chapterName`, `chapterNumber`, `chapterDescription`, `book_FK`) VALUES ('7', 'Psalm 2', '2', 'Why do the nations protest', '2');
INSERT INTO `lecciodivina`.`chapter` (`chapterID`, `chapterName`, `chapterNumber`, `chapterDescription`, `book_FK`) VALUES ('8', 'Psalm3', '3', 'A psalm of David, when he fled from his son Absalom.', '2');


/* --------------------------------------------------------------------------------------- */

INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('1', '0', '(silence)', '1', '1');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('2', '1', 'In the beginning* was the Word, and the Word was with God, and the Word was God.', '2', '6');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('3', '2', 'He was in the beginning with God.', '2', '6');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('4', '3', 'All things came to be through him, and without him nothing came to be. What came to be', '2', '6');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('5', '4', 'through him was life, and this life was the light of the human race;', '2', '6');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('6', '5', 'the light shines in the darkness, and the darkness has not overcome it.', '2', '6');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('7', '6', 'A man named John was sent from God.', '2', '6');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('8', '7', 'He came for testimony, to testify to the light, so that all might believe through him.', '2', '6');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('9', '8', 'He was not the light, but came to testify to the light. ', '2', '6');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('10', '9', 'The true light, which enlightens everyone, was coming into the world.', '2', '6');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('11', '10', 'He was in the world, and the world came to be through him, but the world did not know him.', '2', '6');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('12', '11', 'He came to what was his own, but his own people* did not accept him.', '2', '6');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('13', '12', 'But to those who did accept him he gave power to become children of God, to those who believe in his name,', '2', '6');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('14', '13', 'who were born not by natural generation nor by human choice nor by a man’s decision but of God.', '2', '6');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('15', '14', 'And the Word became flesh and made his dwelling among us, and we saw his glory, the glory as of the Father’s only Son, full of grace and truth.', '2', '6');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('16', '26', 'In the sixth month, the angel Gabriel was sent from God to a town of Galilee called Nazareth ', '2', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('17', '27', 'to a virgin betrothed to a man named Joseph, of the house of David, and the virgin\'s name was Mary ', '2', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('18', '28', 'And coming to her, he said, \"Hail, favored one! The Lord is with you.\"', '2', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('19', '29', 'But she was greatly troubled at what was said and pondered what sort of greeting this might be.', '2', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('20', '30', 'Then the angel said to her, \"Do not be afraid, Mary, for you have found favor with God. ', '2', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('21', '31', 'Behold, you will conceive in your womb and bear a son, and you shall name him Jesus.', '2', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('22', '32', 'He will be great and will be called Son of the Most High, and the Lord God will give him the throne of David his father,', '2', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('23', '33', 'and he will rule over the house of Jacob forever, and of his kingdom there will be no end.\"', '2', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('24', '34', 'But Mary said to the angel, \"How can this be, since I have no relations with a man?', '2', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('25', '35', 'And the angel said to her in reply, The holy Spirit will come upon you, and the power of the Most High will overshadow you. Therefore the child to be born will be called holy, the Son of God. ', '2', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('26', '36', 'And behold, Elizabeth, your relative, has also conceived a son in her old age, and this is the sixth month for her who was called barren;', '2', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('27', '37', 'for nothing will be impossible for God.\"', '2', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('28', '38', 'Mary said, Behold, I am the handmaid of the Lord. May it be done to me according to your word.\" Then the angel departed from her', '2', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('29', '20', 'Such was his intention when, behold, the angel of the Lord* appeared to him in a dream and said, “Joseph, son of David, do not be afraid to take Mary your wife into your home. For it is through the holy Spirit that this child has been conceived in her.', '2', '3');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('30', '21', 'She will bear a son and you are to name him Jesus,* because he will save his people from their sins.”', '2', '3');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('31', '22', 'All this took place to fulfill what the Lord had said through the prophet', '2', '3');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('32', '39', 'During those days Mary set out and traveled to the hill country in haste to a town of Judah, ', '2', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('33', '40', 'where she entered the house of Zechariah and greeted Elizabeth. ', '2', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('34', '41', 'When Elizabeth heard Mary\'s greeting, the infant leaped in her womb, and Elizabeth, filled with the holy Spirit, ', '2', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('35', '42', 'cried out in a loud voice and said, Most blessed are you among women, and blessed is the fruit of your womb. ', '2', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('36', '43', 'And how does this happen to me, that the mother of my Lordshould come to me? ', '2', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('37', '44', 'For at the moment the sound of your greeting reached my ears, the infant in my womb leaped for joy.', '2', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('38', '45', 'Blessed are you who believed that what was spoken to you by the Lord would be fulfilled.\"', '2', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('39', '46', 'And Mary said: \"My soul proclaims the greatness of the Lord;', '2', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('40', '47', 'my spirit rejoices in God my savior. ', '2', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('41', '48', 'For he has looked upon his handmaid\'s lowliness; behold, from now on will all ages call me blessed.', '2', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('42', '49', 'The Mighty One has done great things for me, and holy is his name.', '2', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('43', '50', 'His mercy is from age to age to those who fear him.', '2', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('44', '51', 'He has shown might with his arm, dispersed the arrogant of mind and heart.', '2', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('45', '52', 'He has thrown down the rulers from their thrones but lifted up the lowly.', '2', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('46', '53', 'The hungry he has filled with good things; the rich he has sent away empty.', '2', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('47', '54', 'He has helped Israel his servant, remembering his mercy,', '2', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('48', '55', 'according to his promise to our fathers, to Abraham and to his descendants forever.\"', '2', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('49', '56', 'Mary remained with her about three months and then returned to her home.', '2', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('50', '57', 'When the time arrived for Elizabeth to have her child she gave birth to a son.', '2', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('51', '59', 'When they came on the eighth day to circumciseh the child, they were going to call him Zechariah after his father,', '2', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('52', '63', 'He asked for a tablet and wrote, “John is his name,” and all were amazed.', '2', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('53', '64', 'Immediately his mouth was opened, his tongue freed, and he spoke blessing God.', '2', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('54', '4', 'And Joseph too went up from Galilee from the town of Nazareth to Judea, to the city of David that is called Bethlehem, because he was of the house and family of David,', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('55', '5', 'to be enrolled with Mary, his betrothed, who was with child.', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('56', '6', 'While they were there, the time came for her to have her child,', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('57', '7', 'and she gave birth to her firstborn son. She wrapped him in swaddling clothes and laid him in a manger, because there was no room for them in the inn.', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('58', '8', 'Now there were shepherds in that region living in the fields and keeping the night watch over their flock.', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('59', '9', 'The angel of the Lord appeared to them and the glory of the Lord shone around them, and they were struck with great fear.', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('60', '10', 'The angel said to them, do not be afraid; for behold, I proclaim to you good news of great joy that will be for all the people.', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('61', '11', 'For today in the city of David a savior has been born for you who is Messiah and Lord.', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('62', '13', 'And suddenly there was a multitude of the heavenly host with the angel, praising God and saying:', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('63', '14', 'Glory to God in the highest and on earth peace to those on whom his favor rests.\"', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('64', '15', 'When the angels went away from them to heaven, the shepherds said to one another, Let us go, then, to Bethlehem to see this thing that has taken place, which the Lord has made known to us.\"', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('65', '16', 'So they went in haste and found Mary and Joseph, and the infant lying in the manger.', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('66', '17', 'When they saw this, they made known the message that had been told them about this child.', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('67', '18', 'All who heard it were amazed by what had been told them by the shepherds.', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('68', '1', 'When Jesus was born in Bethlehem of Judea, in the days of King Herod,* behold, magi from the east arrived in Jerusalem,', '3', '3');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('69', '2', 'saying, “Where is the newborn king of the Jews? We saw his star* at its rising and have come to do him homage.”', '3', '3');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('70', '9', 'After their audience with the king they set out. And behold, the star that they had seen at its rising preceded them, until it came and stopped over the place where the child was.', '3', '3');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('71', '10', 'They were overjoyed at seeing the star,', '3', '3');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('72', '11', 'and on entering the house they saw the child with Mary his mother. They prostrated themselves and did him homage. Then they opened their treasures and offered him gifts of gold, frankincense, and myrrh.', '3', '3');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('73', '21', 'When eight days were completed for his circumcision, he was named Jesus, the name given him by the angel before he was conceived in the womb.', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('74', '22', 'When the days were completed for their purification according to the law of Moses, they took him up to Jerusalem to present him to the Lord,', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('75', '23', 'just as it is written in the law of the Lord, ԅvery male that opens the womb shall be consecrated to the Lord,\"', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('76', '24', 'and to offer the sacrifice of \"a pair of turtledoves or two young pigeons,\" in accordance with the dictate in the law of the Lord.', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('77', '25', 'Now there was a man in Jerusalem whose name was Simeon. This man was righteous and devout, awaiting the consolation of Israel, and the holy Spirit was upon him.', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('78', '26', 'It had been revealed to him by the holy Spirit that he should not see death before he had seen the Messiah of the Lord.', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('79', '27', 'He came in the Spirit into the temple; and when the parents brought in the child Jesus to perform the custom of the law in regard to him,', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('80', '28', 'he took him into his arms and blessed God, saying:', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('81', '29', '\"Now, Master, you may let your servant go in peace, according to your word,', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('82', '30', 'for my eyes have seen your salvation,', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('83', '31', 'which you prepared in sight of all the peoples,', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('84', '32', 'a light for revelation to the Gentiles, and glory for your people Israel.\"', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('85', '33', 'The childӳ father and mother were amazed at what was said about him;', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('86', '34', 'and Simeon blessed them and said to Mary his mother, \"Behold, this child is destined for the fall and rise of many in Israel, and to be a sign that will be contradicted', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('87', '35', '(and you yourself a sword will pierce)* so that the thoughts of many hearts may be revealed.\"', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('88', '36', 'There was also a prophetess, Anna, the daughter of Phanuel, of the tribe of Asher. She was advanced in years, having lived seven years with her husband after her marriage,', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('89', '37', 'and then as a widow until she was eighty-four. She never left the temple, but worshiped night and day with fasting and prayer.', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('90', '38', 'And coming forward at that very time, she gave thanks to God and spoke about the child to all who were awaiting the redemption of Jerusalem.', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('91', '39', 'When they had fulfilled all the prescriptions of the law of the Lord, they returned to Galilee, to their own town of Nazareth.', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('92', '40', 'The child grew and became strong, filled with wisdom; and the favor of God was upon him.', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('93', '41', 'Each year his parents went to Jerusalem for the feast of Passover,', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('94', '42', 'and when he was twelve years old, they went up according to festival custom.', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('95', '43', 'After they had completed its days, as they were returning, the boy Jesus remained behind in Jerusalem, but his parents did not know it.', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('96', '44', 'Thinking that he was in the caravan, they journeyed for a day and looked for him among their relatives and acquaintances,', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('97', '45', 'but not finding him, they returned to Jerusalem to look for him.', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('98', '46', 'After three days they found him in the temple, sitting in the midst of the teachers, listening to them and asking them questions,', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('99', '47', 'and all who heard him were astounded at his understanding and his answers.', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('100', '48', 'When his parents saw him, they were astonished, and his mother said to him, ԓon, why have you done this to us? Your father and I have been looking for you with great anxiety.\"', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('101', '49', 'And he said to them, \"Why were you looking for me? Did you not know that I must be in my Father\'s house?\"', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('102', '50', 'But they did not understand what he said to them.', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('103', '51', 'He went down with them and came to Nazareth, and was obedient to them; and his mother kept all these things in her heart.', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('104', '52', 'And Jesus advanced [in] wisdom and age and favor before God and man.', '3', '5');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('105', '1', 'Blessed is the man who does not walk in the counsel of the wicked, Nor stand in the way* of sinners, nor sit in company with scoffers.a', '2', '2');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('106', '2', 'Rather, the law of the LORD* is his joy; and on his law he meditates day and night', '2', '2');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('107', '3', 'He is like a tree planted near streams of water, that yields its fruit in season; Its leaves never wither; whatever he does prospers.', '2', '2');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('108', '4', 'But not so are the wicked, not so! They are like chaff driven by the wind.', '2', '2');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('109', '5', 'Therefore the wicked will not arise at the judgment, nor will sinners in the assembly of the just.', '2', '2');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('110', '6', 'Because the LORD knows the way of the just, but the way of the wicked leads to ruin.', '2', '2');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('111', '1', 'Why do the nations protest and the peoples conspire in vain?', '3', '2');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('112', '2', 'Kings on earth rise up and princes plot together against the LORD and against his anointed one:', '3', '2');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('113', '3', '“Let us break their shackles and cast off their chains from us!”', '3', '2');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('114', '4', 'The one enthroned in heaven laughs; the Lord derides them,', '3', '2');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('115', '5', 'Then he speaks to them in his anger, in his wrath he terrifies them:', '3', '2');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('116', '6', '“I myself have installed my king on Zion, my holy mountain.”', '3', '2');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('117', '7', 'I will proclaim the decree of the LORD, he said to me, “You are my son; today I have begotten you.', '3', '2');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('118', '8', 'Ask it of me, and I will give you the nations as your inheritance, and, as your possession, the ends of the earth.', '3', '2');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('119', '9', 'With an iron rod you will shepherd them, like a potter’s vessel you will shatter them.”', '3', '2');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('120', '10', 'And now, kings, give heed; take warning, judges on earth.', '3', '2');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('121', '11', 'Serve the LORD with fear; exult with trembling, Accept correction lest he become angry and you perish along the way when his anger suddenly blazes up. Blessed are all who take refuge in him!', '3', '2');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('122', '1', 'A psalm of David, when he fled from his son Absalom.', '3', '2');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('123', '2', 'I How many are my foes, LORD! How many rise against me!', '3', '2');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('124', '3', 'How many say of me, “There is no salvation for him in God.” Selah', '3', '2');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('125', '4', 'But you, LORD, are a shield around me; my glory, you keep my head high.', '3', '2');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('126', '5', 'II With my own voice I will call out to the LORD, and he will answer me from his holy mountain. Selah', '3', '2');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('127', '6', 'I lie down and I fall asleep, [and] I will wake up, for the LORD sustains me.', '3', '2');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('128', '7', 'I do not fear, then, thousands of people arrayed against me on every side.', '3', '2');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('129', '8', 'III Arise, LORD! Save me, my God! For you strike the cheekbone of all my foes; you break the teeth of the wicked.', '3', '2');
INSERT INTO `lecciodivina`.`verse` (`verseID`, `verseNumber`, `verseString`, `chapter_FK`, `book_FK`) VALUES ('130', '9', 'Salvation is from the LORD! May your blessing be upon your people! Selah', '3', '2');

/* --------------------------------------------------------------------------------------- */

INSERT INTO `lecciodivina`.`prayertype` (`prayerTypeID`, `prayerTypeName`) VALUES ('1', '---');
INSERT INTO `lecciodivina`.`prayertype` (`prayerTypeID`, `prayerTypeName`) VALUES ('2', 'The Sign of the Cross');
INSERT INTO `lecciodivina`.`prayertype` (`prayerTypeID`, `prayerTypeName`) VALUES ('3', 'The Apostles\' Creed');
INSERT INTO `lecciodivina`.`prayertype` (`prayerTypeID`, `prayerTypeName`) VALUES ('4', 'The Our Father');
INSERT INTO `lecciodivina`.`prayertype` (`prayerTypeID`, `prayerTypeName`) VALUES ('5', 'The Hail Mary');
INSERT INTO `lecciodivina`.`prayertype` (`prayerTypeID`, `prayerTypeName`) VALUES ('6', 'The Glory Be (The Doxology)');
INSERT INTO `lecciodivina`.`prayertype` (`prayerTypeID`, `prayerTypeName`) VALUES ('7', 'The Fatima Prayer');
INSERT INTO `lecciodivina`.`prayertype` (`prayerTypeID`, `prayerTypeName`) VALUES ('8', 'The Hail Holy Queen (The Salve Regina)');
INSERT INTO `lecciodivina`.`prayertype` (`prayerTypeID`, `prayerTypeName`) VALUES ('9', 'Let us pray');

/* --------------------------------------------------------------------------------------- */

INSERT INTO `lecciodivina`.`prayertext` (`prayertextID`, `prayertextName`, `prayertextString`, `prayerType_FK`, `lexicon_FK`) VALUES ('1', '---', '---', '1', '2');
INSERT INTO `lecciodivina`.`prayertext` (`prayertextID`, `prayertextName`, `prayertextString`, `prayerType_FK`, `lexicon_FK`) VALUES ('2', 'Sign of the Cross', 'In the name of the Father of the Son and of the Holy Spirit. Amen', '2', '2');
INSERT INTO `lecciodivina`.`prayertext` (`prayertextID`, `prayertextName`, `prayertextString`, `prayerType_FK`, `lexicon_FK`) VALUES ('3', 'La Señal de la Cruz', 'En el nombre del Padre, del Hijo y del Espíritu Santo. Amén.', '2', '3');
INSERT INTO `lecciodivina`.`prayertext` (`prayertextID`, `prayertextName`, `prayertextString`, `prayerType_FK`, `lexicon_FK`) VALUES ('4', 'In nómine Patris', 'In nómine Patris, et Fílii, et Spíritus Sancti. Amen.', '2', '4');
INSERT INTO `lecciodivina`.`prayertext` (`prayertextID`, `prayertextName`, `prayertextString`, `prayerType_FK`, `lexicon_FK`) VALUES ('5', 'Apostles\' Creed', 'I believe in God, the Father almighty, Creator of heaven and earth, and in Jesus Christ, his only Son, our Lord, who was conceived by the Holy Spirit, born of the Virgin Mary, suffered under Pontius Pilate, was crucified, died and was buried; he descended into hell; on the third day he rose again from the dead; he ascended into heaven, and is seated at the right hand of God the Father almighty; from there he will come to judge the living and the dead. I believe in the Holy Spirit, the holy catholic Church, the communion of saints, the forgiveness of sins, the resurrection of the body, and life everlasting. Amen.', '3', '2');
INSERT INTO `lecciodivina`.`prayertext` (`prayertextID`, `prayertextName`, `prayertextString`, `prayerType_FK`, `lexicon_FK`) VALUES ('6', 'El Credo de los Apóstoles', 'Creo en un solo Dios, Padre Todopoderoso, Creador del cielo y de la tierra, de todo lo visible y lo invisible. Creo en un solo Señor Jesucristo, hijo único de Dios, nacido del Padre ante todos los siglos, Dios de Dios, Luz de Luz, Dios Verdadero de Dios Verdadero, engendrado, no creado, de la misma naturaleza del Padre por quien todo fué hecho, que por nosotros los hombres y por nuestra salvación bajó del cielo. Y por obra del Espíritu Santo se encarnó de la Virgen María y se hizó hombre. Y por nuestra causa fué crucificado en tiempos de Poncio Pilatos, padeció y fué sepulatdo y resucitó al tercer día según las Escrituras y subió al cielo. Y está sentado a la derecha del Padre y de nuevo vendrá con Gloria para juzgar a vivos y muertos y su reino no tendrá fin. Creo en el Espíritu Santo, Señor y dador de vida que procede del Padre y el Hijo, que con el Padre y el Hijo reciben una misma adoración y Gloria que habló por los profetas. Creo en la iglesia que es una: Santa, Católica y Apostólica, confieso que hay un solo bautismo para el perdon de los pecados. Espero la resurrección de los muertos y la vida del mundo futuro Amén.', '3', '3');
INSERT INTO `lecciodivina`.`prayertext` (`prayertextID`, `prayertextName`, `prayertextString`, `prayerType_FK`, `lexicon_FK`) VALUES ('7', 'Credo in Deum', 'Credo in Deum Patrem omnipoténtem, Creatórem cæli et terræ. Et in Iesum Christum, Fílium eius únicum, Dóminum nostrum, qui concéptus est de Spíritu Sancto, natus ex María Vírgine, passus sub Póntio Piláto, crucifíxus, mórtuus, et sepúltus, descéndit ad ínfernos, tértia die resurréxit a mórtuis, ascéndit ad cælos, sedet ad déxteram Dei Patris omnipoténtis, inde ventúrus est iudicáre vivos et mórtuos. Credo in Spíritum Sanctum, sanctam Ecclésiam cathólicam, sanctórum communiónem, remissiónem peccatórum, carnis resurrectiónem, vitam ætérnam. Amen.', '3', '4');
INSERT INTO `lecciodivina`.`prayertext` (`prayertextID`, `prayertextName`, `prayertextString`, `prayerType_FK`, `lexicon_FK`) VALUES ('8', 'Our Father', 'Our Father, who art in heaven, hallowed be thy name; thy kingdom come; thy will be done on earth as it is in heaven. Give us this day our daily bread; and forgive us our trespasses as we forgive those who trespass against us; and lead us not into temptation, but deliver us from evil. Amen', '4', '2');
INSERT INTO `lecciodivina`.`prayertext` (`prayertextID`, `prayertextName`, `prayertextString`, `prayerType_FK`, `lexicon_FK`) VALUES ('9', 'El Padre Nuestro', 'Padre Nuestro que estas en los cielos. Santificado sea tu nombre venga a nosotros tu reino. Hágase tu voluntad en la tierra, como en el cielo. Dános hoy nuestro pan de cada día y perdona nuestras ofensas como también nosotros perdonamos alos que nos ofenden. No nos dejes caer en tentación y líbranos del mal. Amén.', '4', '3');
INSERT INTO `lecciodivina`.`prayertext` (`prayertextID`, `prayertextName`, `prayertextString`, `prayerType_FK`, `lexicon_FK`) VALUES ('10', 'Pater noster', 'Pater noster, qui es in cælis, sanctificétur nomen tuum. Advéniat regnum tuum. Fiat volúntas tua, sicut in cælo, et in terra. Panem nostrum cotidiánum da nobis hódie, et dimítte nobis débita nostra sicut et nos dimíttimus debitóribus nostris. Et ne nos indúcas in tentatiónem, sed líbera nos a malo. Amen.', '4', '4');
INSERT INTO `lecciodivina`.`prayertext` (`prayertextID`, `prayertextName`, `prayertextString`, `prayerType_FK`, `lexicon_FK`) VALUES ('11', 'Hail Mary', 'Hail Mary, full of grace, the Lord is with you; blessed are you among women, and blessed is the fruit of your womb, Jesus. Holy Mary, Mother of God, pray for us sinners now and at the hour of our death. Amen.', '5', '2');
INSERT INTO `lecciodivina`.`prayertext` (`prayertextID`, `prayertextName`, `prayertextString`, `prayerType_FK`, `lexicon_FK`) VALUES ('12', 'Ave María', 'Dios te salve María llena eres de Gracia, el Señor es contigo. Bendita eres entre todas las mujeres y bendito es el fruto de tu vientre Jesús. Santa María, Madre de Dios, ruega por nosotros los pecadores ahora y en la hora de nuestra muerte. Amén.', '5', '3');
INSERT INTO `lecciodivina`.`prayertext` (`prayertextID`, `prayertextName`, `prayertextString`, `prayerType_FK`, `lexicon_FK`) VALUES ('13', 'Ave María', 'Ave María, grátia plena, Dóminus tecum. Benedícta tu in muliéribus, et benedíctus fructus ventris tui, Iesus. Sancta María, Mater Dei, ora pro nobis peccatóribus, nunc, et in hora mortis nostræ. Amen.', '5', '4');
INSERT INTO `lecciodivina`.`prayertext` (`prayertextID`, `prayertextName`, `prayertextString`, `prayerType_FK`, `lexicon_FK`) VALUES ('14', 'Glory Be (The Doxology)', 'Glory be to the Father, the Son, and the Holy Spirit; as it was in the beginning, is now, and ever shall be, world without end. Amen.', '6', '2');
INSERT INTO `lecciodivina`.`prayertext` (`prayertextID`, `prayertextName`, `prayertextString`, `prayerType_FK`, `lexicon_FK`) VALUES ('15', 'Gloria', 'Gloria al Padre, y al Hijo y al Espíritu Santo, como era en el principio, ahora y siempre, por los siglos de los siglos. Amén.', '6', '3');
INSERT INTO `lecciodivina`.`prayertext` (`prayertextID`, `prayertextName`, `prayertextString`, `prayerType_FK`, `lexicon_FK`) VALUES ('16', 'Glória Patri', 'Glória Patri, et Fílio, et Spirítui Sancto. Sicut erat in princípio, et nunc, et semper, et in sæcula sæculórum. Amen.', '6', '4');
INSERT INTO `lecciodivina`.`prayertext` (`prayertextID`, `prayertextName`, `prayertextString`, `prayerType_FK`, `lexicon_FK`) VALUES ('17', 'Fatima Prayer', 'O my Jesus, forgive us our sins, save us from the fires of hell, and lead all souls to Heaven, especially those in most need of Your Mercy.', '7', '2');
INSERT INTO `lecciodivina`.`prayertext` (`prayertextID`, `prayertextName`, `prayertextString`, `prayerType_FK`, `lexicon_FK`) VALUES ('18', 'La Oración de Fátima', 'Oh, Jesús mío, perdona nuestros pecados, líbranos del fuego del infierno, y lleva nuestras almas al cielo, especialmente aquellos que necesitan más Tu Misericordia', '7', '3');
INSERT INTO `lecciodivina`.`prayertext` (`prayertextID`, `prayertextName`, `prayertextString`, `prayerType_FK`, `lexicon_FK`) VALUES ('19', 'Domine Iesu', 'Domine Iesu, dimitte nobis debita nostra, salva nos ab igne inferiori, perduc in cælum omnes animas, præsertim eas, quæ misericordiæ tuæ maxime indigent. Amen.', '7', '4');
INSERT INTO `lecciodivina`.`prayertext` (`prayertextID`, `prayertextName`, `prayertextString`, `prayerType_FK`, `lexicon_FK`) VALUES ('20', 'The Hail Holy Queen (The Salve Regina)', 'Hail, holy Queen, mother of mercy, our life, our sweetness, and our hope. To you we cry, poor banished children of Eve; to you we send up our sighs, mourning and weeping in this valley of tears. Turn, then, most gracious advocate, your eyes of mercy toward us; and after this, our exile, show unto us the blessed fruit of your womb, Jesus. O clement, O loving, O sweet Virgin Mary.', '8', '2');
INSERT INTO `lecciodivina`.`prayertext` (`prayertextID`, `prayertextName`, `prayertextString`, `prayerType_FK`, `lexicon_FK`) VALUES ('21', 'Salve Regína', 'Dios te salve, Reina y Madre de misericordia, vida, dulzura y esperanza nuestra. Dios te Salve. A ti llamamos los desterrados hijos de Eva, a ti suspiramos gimiendo y llorando en este valle de lágrimas. Ea! pues Señora abogada nuestra, vuelve a nosotros esos tus ojos misericordiosos y después de este destierro, muéstranos a Jesús fruto bendito de tu vientre. Oh Clemente! Oh Piadosa! Oh Dulce Siempre Virgen María! Ruega por nosotros Santa Madre de Dios para que seamos dignos de alcanzar las promesas de Nuestro Señor Jesucristo. Amén.', '8', '3');
INSERT INTO `lecciodivina`.`prayertext` (`prayertextID`, `prayertextName`, `prayertextString`, `prayerType_FK`, `lexicon_FK`) VALUES ('22', 'Salve Regína', 'Salve Regína, Mater misericórdiæ; Vita dulcédo, et spes nostra, salve. Ad te Clamámus éxsules fílii Evæ; Ad te Suspirámus, geméntes et flentes in hac lacrimárum valle. Eia ergo, Advocáta nostra, Illos tuos misericórdes óculos ad nos convérte: Et Iesum, benedíctum fructum ventris tui, Nobis post hoc exsílium osténde. O clemens, o pia, o dulcis Virgo María. V/. Ora pro nobis, Sancta Dei Génetrix. R/. Ut digni efficiámur promissionibus Christi. Amen.', '8', '4');
INSERT INTO `lecciodivina`.`prayertext` (`prayertextID`, `prayertextName`, `prayertextString`, `prayerType_FK`, `lexicon_FK`) VALUES ('23', 'Let us pray', 'Let us pray. O GOD, whose only begotten Son, by His life, death, and resurrection, has purchased for us the rewards of eternal life, grant, we beseech Thee, that meditating upon these mysteries of the Most Holy Rosary of the Blessed Virgin Mary, we may imitate what they contain and obtain what they promise, through the same Christ Our Lord. Amen.', '9', '2');
INSERT INTO `lecciodivina`.`prayertext` (`prayertextID`, `prayertextName`, `prayertextString`, `prayerType_FK`, `lexicon_FK`) VALUES ('24', 'Oremus', 'Oh Dios de quién Único Hijo nos ha otorgado los beneficios de la vida eterna, concédenos la gracia que te pedimos mientras meditamos los Misterios del Mas Santo Rosario de la Bienaventurada Virgen María, debemos imitar lo que contienen y obtener lo que prometen, a través del mismo Cristo Nuestro Señor. Amen.', '9', '3');
INSERT INTO `lecciodivina`.`prayertext` (`prayertextID`, `prayertextName`, `prayertextString`, `prayerType_FK`, `lexicon_FK`) VALUES ('25', 'Oremus', 'Deus, cujus Unigénitus, per vitam, mortem et resurrectiónem suam nobis salútis ætérnæ præmia comparávit: concéde, quæsumus; ut, hæc mystéria sanctíssimo beátæ Maríæ Virginis Rosário recoléntes; et imitémur quod cóntinent, et quod promíttunt, assequámur. Per eúmdem Christum Dóminum nostrum. Amen.', '9', '4');
INSERT INTO `lecciodivina`.`prayertext` (`prayertextID`, `prayertextName`, `prayertextString`, `prayerType_FK`, `lexicon_FK`) VALUES ('26', '---', '---', '1', '3');
INSERT INTO `lecciodivina`.`prayertext` (`prayertextID`, `prayertextName`, `prayertextString`, `prayerType_FK`, `lexicon_FK`) VALUES ('27', '---', '---', '1', '4');


/* --------------------------------------------------------------------------------------- */

INSERT INTO `lecciodivina`.`mysterytype` (`mysterytypeID`, `mysterytypeName`, `mysterytypeDescription`) VALUES ('1', '---', '---');
INSERT INTO `lecciodivina`.`mysterytype` (`mysterytypeID`, `mysterytypeName`, `mysterytypeDescription`) VALUES ('2', 'Joyful Mystery', 'first');
INSERT INTO `lecciodivina`.`mysterytype` (`mysterytypeID`, `mysterytypeName`, `mysterytypeDescription`) VALUES ('3', 'Sorrowful Mystery', 'second');
INSERT INTO `lecciodivina`.`mysterytype` (`mysterytypeID`, `mysterytypeName`, `mysterytypeDescription`) VALUES ('4', 'Glorious Mystery', 'third');
INSERT INTO `lecciodivina`.`mysterytype` (`mysterytypeID`, `mysterytypeName`, `mysterytypeDescription`) VALUES ('5', 'Luminous Mystery', 'fourth');

/* --------------------------------------------------------------------------------------- */

INSERT INTO `lecciodivina`.`mysterytext` (`mysterytextID`, `mystertextName`, `mysterytextDescription`, `mysteryType_FK`, `lexicon_FK`) VALUES ('1', '---', '---', '1', '1');
INSERT INTO `lecciodivina`.`mysterytext` (`mysterytextID`, `mystertextName`, `mysterytextDescription`, `mysteryType_FK`, `lexicon_FK`) VALUES ('2', 'The Annunciation of the Angel to Mary', 'First Joyful Mystery', '2', '2');
INSERT INTO `lecciodivina`.`mysterytext` (`mysterytextID`, `mystertextName`, `mysterytextDescription`, `mysteryType_FK`, `lexicon_FK`) VALUES ('3', 'The visitation of Mary to Saint Elizabeth', 'Second Joyful Mystery', '2', '2');
INSERT INTO `lecciodivina`.`mysterytext` (`mysterytextID`, `mystertextName`, `mysterytextDescription`, `mysteryType_FK`, `lexicon_FK`) VALUES ('4', 'The nativity of Jesus in Bethlehem', 'Third Joyful Mystery', '2', '2');
INSERT INTO `lecciodivina`.`mysterytext` (`mysterytextID`, `mystertextName`, `mysterytextDescription`, `mysteryType_FK`, `lexicon_FK`) VALUES ('5', 'The presentation of Jesus to the Temple', 'Fourth Joyful Mystery', '2', '2');
INSERT INTO `lecciodivina`.`mysterytext` (`mysterytextID`, `mystertextName`, `mysterytextDescription`, `mysteryType_FK`, `lexicon_FK`) VALUES ('6', 'The finding of Jesus in the Temple', 'Fifth Joyful Mystery', '2', '2');
INSERT INTO `lecciodivina`.`mysterytext` (`mysterytextID`, `mystertextName`, `mysterytextDescription`, `mysteryType_FK`, `lexicon_FK`) VALUES ('7', 'The Baptism of Jesus', 'First Luminous Mystery', '3', '2');
INSERT INTO `lecciodivina`.`mysterytext` (`mysterytextID`, `mystertextName`, `mysterytextDescription`, `mysteryType_FK`, `lexicon_FK`) VALUES ('8', 'The wedding of Cana', 'Second Luminous Mystery', '3', '2');
INSERT INTO `lecciodivina`.`mysterytext` (`mysterytextID`, `mystertextName`, `mysterytextDescription`, `mysteryType_FK`, `lexicon_FK`) VALUES ('9', 'The proclamation of the Kingdom of God', 'Third Luminous Mystery', '3', '2');
INSERT INTO `lecciodivina`.`mysterytext` (`mysterytextID`, `mystertextName`, `mysterytextDescription`, `mysteryType_FK`, `lexicon_FK`) VALUES ('10', 'The Transfiguration', 'Fourth Luminous Mystery', '3', '2');
INSERT INTO `lecciodivina`.`mysterytext` (`mysterytextID`, `mystertextName`, `mysterytextDescription`, `mysteryType_FK`, `lexicon_FK`) VALUES ('11', 'The institution of the Eucharist', 'Fifth Luminous Mystery', '3', '2');
INSERT INTO `lecciodivina`.`mysterytext` (`mysterytextID`, `mystertextName`, `mysterytextDescription`, `mysteryType_FK`, `lexicon_FK`) VALUES ('12', 'The Agony of Jesus in the garden', 'First Sorrowful Mystery', '4', '2');
INSERT INTO `lecciodivina`.`mysterytext` (`mysterytextID`, `mystertextName`, `mysterytextDescription`, `mysteryType_FK`, `lexicon_FK`) VALUES ('13', 'The scourging of Jesus at the pillar', 'Second Sorrowful Mystery', '4', '2');
INSERT INTO `lecciodivina`.`mysterytext` (`mysterytextID`, `mystertextName`, `mysterytextDescription`, `mysteryType_FK`, `lexicon_FK`) VALUES ('14', 'The Crowning with Thorns', 'Third Sorrowful Mystery', '4', '2');
INSERT INTO `lecciodivina`.`mysterytext` (`mysterytextID`, `mystertextName`, `mysterytextDescription`, `mysteryType_FK`, `lexicon_FK`) VALUES ('15', 'The Carrying of the Cross', 'Fourth Sorrowful Mystery', '4', '2');
INSERT INTO `lecciodivina`.`mysterytext` (`mysterytextID`, `mystertextName`, `mysterytextDescription`, `mysteryType_FK`, `lexicon_FK`) VALUES ('16', 'The crucifixion and death of Jesus', 'Fifth Sorrowful Mystery', '4', '2');
INSERT INTO `lecciodivina`.`mysterytext` (`mysterytextID`, `mystertextName`, `mysterytextDescription`, `mysteryType_FK`, `lexicon_FK`) VALUES ('17', 'The Resurrection of Jesus Christ', 'First Glorious Mystery', '5', '2');
INSERT INTO `lecciodivina`.`mysterytext` (`mysterytextID`, `mystertextName`, `mysterytextDescription`, `mysteryType_FK`, `lexicon_FK`) VALUES ('18', 'The Ascension of Jesus to Heaven', 'Second Glorious Mystery', '5', '2');
INSERT INTO `lecciodivina`.`mysterytext` (`mysterytextID`, `mystertextName`, `mysterytextDescription`, `mysteryType_FK`, `lexicon_FK`) VALUES ('19', 'The Descent of the Holy Ghost', 'Third Glorious Mystery', '5', '2');
INSERT INTO `lecciodivina`.`mysterytext` (`mysterytextID`, `mystertextName`, `mysterytextDescription`, `mysteryType_FK`, `lexicon_FK`) VALUES ('20', 'The Assumption of the Blessed Virgin Mary', 'Fourth Glorious Mystery', '5', '2');
INSERT INTO `lecciodivina`.`mysterytext` (`mysterytextID`, `mystertextName`, `mysterytextDescription`, `mysteryType_FK`, `lexicon_FK`) VALUES ('21', 'The Coronation of the Blessed Virgin Mary', 'Fifth Glorious Mystery', '5', '2');


/* --------------------------------------------------------------------------------------- */

INSERT INTO `lecciodivina`.`meditation` (`meditationID`, `meditationNumber`, `meditationName`, `meditationDescription`, `lexicon_FK`) VALUES ('1', '1', '1st joyful', '1st joyful mystery - The Annunciation of the Angel to Mary', '2');


/* --------------------------------------------------------------------------------------- */

INSERT INTO `lecciodivina`.`beadtype` (`beadTypeID`, `beadTypeName`, `prayertype_FK`, `mysterytype_FK`, `lexicon_FK`) VALUES ('1', '---', '1', '1', '1');
INSERT INTO `lecciodivina`.`beadtype` (`beadTypeID`, `beadTypeName`, `prayertype_FK`, `mysterytype_FK`, `lexicon_FK`) VALUES ('2', 'start', '2', '1', '1');
INSERT INTO `lecciodivina`.`beadtype` (`beadTypeID`, `beadTypeName`, `prayertype_FK`, `mysterytype_FK`, `lexicon_FK`) VALUES ('3', 'chain space pt1', '6', '1', '1');
INSERT INTO `lecciodivina`.`beadtype` (`beadTypeID`, `beadTypeName`, `prayertype_FK`, `mysterytype_FK`, `lexicon_FK`) VALUES ('4', 'chain space pt2', '7', '1', '1');
INSERT INTO `lecciodivina`.`beadtype` (`beadTypeID`, `beadTypeName`, `prayertype_FK`, `mysterytype_FK`, `lexicon_FK`) VALUES ('5', 'end', '1', '1', '1');
INSERT INTO `lecciodivina`.`beadtype` (`beadTypeID`, `beadTypeName`, `prayertype_FK`, `mysterytype_FK`, `lexicon_FK`) VALUES ('6', 'Crucifix Joyful', '3', '2', '2');
INSERT INTO `lecciodivina`.`beadtype` (`beadTypeID`, `beadTypeName`, `prayertype_FK`, `mysterytype_FK`, `lexicon_FK`) VALUES ('7', 'Crucifix Sorrowful', '3', '3', '2');
INSERT INTO `lecciodivina`.`beadtype` (`beadTypeID`, `beadTypeName`, `prayertype_FK`, `mysterytype_FK`, `lexicon_FK`) VALUES ('8', 'Crucifix  Glorious', '3', '4', '2');
INSERT INTO `lecciodivina`.`beadtype` (`beadTypeID`, `beadTypeName`, `prayertype_FK`, `mysterytype_FK`, `lexicon_FK`) VALUES ('9', 'Crucifix Luminous', '3', '5', '2');
INSERT INTO `lecciodivina`.`beadtype` (`beadTypeID`, `beadTypeName`, `prayertype_FK`, `mysterytype_FK`, `lexicon_FK`) VALUES ('10', 'big bead joyful', '4', '2', '2');
INSERT INTO `lecciodivina`.`beadtype` (`beadTypeID`, `beadTypeName`, `prayertype_FK`, `mysterytype_FK`, `lexicon_FK`) VALUES ('11', 'big bead sorrowful', '4', '3', '2');
INSERT INTO `lecciodivina`.`beadtype` (`beadTypeID`, `beadTypeName`, `prayertype_FK`, `mysterytype_FK`, `lexicon_FK`) VALUES ('12', 'big bead glorious', '4', '4', '2');
INSERT INTO `lecciodivina`.`beadtype` (`beadTypeID`, `beadTypeName`, `prayertype_FK`, `mysterytype_FK`, `lexicon_FK`) VALUES ('13', 'big bead luminous', '4', '5', '2');
INSERT INTO `lecciodivina`.`beadtype` (`beadTypeID`, `beadTypeName`, `prayertype_FK`, `mysterytype_FK`, `lexicon_FK`) VALUES ('14', 'Decade Joyful', '5', '2', '2');
INSERT INTO `lecciodivina`.`beadtype` (`beadTypeID`, `beadTypeName`, `prayertype_FK`, `mysterytype_FK`, `lexicon_FK`) VALUES ('15', 'Decade Sorrowful', '5', '3', '2');
INSERT INTO `lecciodivina`.`beadtype` (`beadTypeID`, `beadTypeName`, `prayertype_FK`, `mysterytype_FK`, `lexicon_FK`) VALUES ('16', 'Decade Glorious', '5', '4', '2');
INSERT INTO `lecciodivina`.`beadtype` (`beadTypeID`, `beadTypeName`, `prayertype_FK`, `mysterytype_FK`, `lexicon_FK`) VALUES ('17', 'Decade  Luminous', '5', '5', '2');
INSERT INTO `lecciodivina`.`beadtype` (`beadTypeID`, `beadTypeName`, `prayertype_FK`, `mysterytype_FK`, `lexicon_FK`) VALUES ('18', 'Antiphon Our Father', '4', '2', '2');
INSERT INTO `lecciodivina`.`beadtype` (`beadTypeID`, `beadTypeName`, `prayertype_FK`, `mysterytype_FK`, `lexicon_FK`) VALUES ('19', 'Antiphon Our Father', '4', '3', '2');
INSERT INTO `lecciodivina`.`beadtype` (`beadTypeID`, `beadTypeName`, `prayertype_FK`, `mysterytype_FK`, `lexicon_FK`) VALUES ('20', 'Antiphon Our Father', '4', '4', '2');
INSERT INTO `lecciodivina`.`beadtype` (`beadTypeID`, `beadTypeName`, `prayertype_FK`, `mysterytype_FK`, `lexicon_FK`) VALUES ('21', 'Antiphon Our Father', '4', '5', '2');
INSERT INTO `lecciodivina`.`beadtype` (`beadTypeID`, `beadTypeName`, `prayertype_FK`, `mysterytype_FK`, `lexicon_FK`) VALUES ('22', 'Antiphon HailMary', '5', '2', '2');
INSERT INTO `lecciodivina`.`beadtype` (`beadTypeID`, `beadTypeName`, `prayertype_FK`, `mysterytype_FK`, `lexicon_FK`) VALUES ('23', 'Antiphon HailMary', '5', '3', '2');
INSERT INTO `lecciodivina`.`beadtype` (`beadTypeID`, `beadTypeName`, `prayertype_FK`, `mysterytype_FK`, `lexicon_FK`) VALUES ('24', 'Antiphon HailMary', '5', '4', '2');
INSERT INTO `lecciodivina`.`beadtype` (`beadTypeID`, `beadTypeName`, `prayertype_FK`, `mysterytype_FK`, `lexicon_FK`) VALUES ('25', 'Antiphon HailMary', '5', '5', '2');
INSERT INTO `lecciodivina`.`beadtype` (`beadTypeID`, `beadTypeName`, `prayertype_FK`, `mysterytype_FK`, `lexicon_FK`) VALUES ('26', 'Antiphon GloryBe', '6', '2', '2');
INSERT INTO `lecciodivina`.`beadtype` (`beadTypeID`, `beadTypeName`, `prayertype_FK`, `mysterytype_FK`, `lexicon_FK`) VALUES ('27', 'Antiphon GloryBe', '6', '3', '2');
INSERT INTO `lecciodivina`.`beadtype` (`beadTypeID`, `beadTypeName`, `prayertype_FK`, `mysterytype_FK`, `lexicon_FK`) VALUES ('28', 'Antiphon GloryBe', '6', '4', '2');
INSERT INTO `lecciodivina`.`beadtype` (`beadTypeID`, `beadTypeName`, `prayertype_FK`, `mysterytype_FK`, `lexicon_FK`) VALUES ('29', 'Antiphon GloryBe', '6', '5', '2');


/* --------------------------------------------------------------------------------------- */

INSERT INTO `lecciodivina`.`bead` (`beadID`, `beadNumber`, `beadtype_FK`, `meditation_FK`, `verse_FK`) VALUES ('1', '0', '2', '1', '1');
INSERT INTO `lecciodivina`.`bead` (`beadID`, `beadNumber`, `beadtype_FK`, `meditation_FK`, `verse_FK`) VALUES ('2', '1', '6', '1', '1');
INSERT INTO `lecciodivina`.`bead` (`beadID`, `beadNumber`, `beadtype_FK`, `meditation_FK`, `verse_FK`) VALUES ('3', '2', '18', '1', '1');
INSERT INTO `lecciodivina`.`bead` (`beadID`, `beadNumber`, `beadtype_FK`, `meditation_FK`, `verse_FK`) VALUES ('4', '3', '22', '1', '1');
INSERT INTO `lecciodivina`.`bead` (`beadID`, `beadNumber`, `beadtype_FK`, `meditation_FK`, `verse_FK`) VALUES ('5', '4', '22', '1', '1');
INSERT INTO `lecciodivina`.`bead` (`beadID`, `beadNumber`, `beadtype_FK`, `meditation_FK`, `verse_FK`) VALUES ('6', '5', '22', '1', '1');
INSERT INTO `lecciodivina`.`bead` (`beadID`, `beadNumber`, `beadtype_FK`, `meditation_FK`, `verse_FK`) VALUES ('7', '6', '26', '1', '1');
INSERT INTO `lecciodivina`.`bead` (`beadID`, `beadNumber`, `beadtype_FK`, `meditation_FK`, `verse_FK`) VALUES ('8', '7', '10', '1', '1');
INSERT INTO `lecciodivina`.`bead` (`beadID`, `beadNumber`, `beadtype_FK`, `meditation_FK`, `verse_FK`) VALUES ('9', '8', '14', '1', '2');
INSERT INTO `lecciodivina`.`bead` (`beadID`, `beadNumber`, `beadtype_FK`, `meditation_FK`, `verse_FK`) VALUES ('10', '8', '14', '1', '3');
INSERT INTO `lecciodivina`.`bead` (`beadID`, `beadNumber`, `beadtype_FK`, `meditation_FK`, `verse_FK`) VALUES ('11', '8', '14', '1', '4');
INSERT INTO `lecciodivina`.`bead` (`beadID`, `beadNumber`, `beadtype_FK`, `meditation_FK`, `verse_FK`) VALUES ('12', '8', '14', '1', '5');
INSERT INTO `lecciodivina`.`bead` (`beadID`, `beadNumber`, `beadtype_FK`, `meditation_FK`, `verse_FK`) VALUES ('13', '8', '14', '1', '6');
INSERT INTO `lecciodivina`.`bead` (`beadID`, `beadNumber`, `beadtype_FK`, `meditation_FK`, `verse_FK`) VALUES ('14', '8', '14', '1', '7');
INSERT INTO `lecciodivina`.`bead` (`beadID`, `beadNumber`, `beadtype_FK`, `meditation_FK`, `verse_FK`) VALUES ('15', '8', '14', '1', '8');
INSERT INTO `lecciodivina`.`bead` (`beadID`, `beadNumber`, `beadtype_FK`, `meditation_FK`, `verse_FK`) VALUES ('16', '8', '14', '1', '9');
INSERT INTO `lecciodivina`.`bead` (`beadID`, `beadNumber`, `beadtype_FK`, `meditation_FK`, `verse_FK`) VALUES ('17', '8', '14', '1', '10');
INSERT INTO `lecciodivina`.`bead` (`beadID`, `beadNumber`, `beadtype_FK`, `meditation_FK`, `verse_FK`) VALUES ('18', '8', '14', '1', '11');
INSERT INTO `lecciodivina`.`bead` (`beadID`, `beadNumber`, `beadtype_FK`, `meditation_FK`, `verse_FK`) VALUES ('19', '8', '14', '1', '12');
INSERT INTO `lecciodivina`.`bead` (`beadID`, `beadNumber`, `beadtype_FK`, `meditation_FK`, `verse_FK`) VALUES ('20', '8', '14', '1', '13');
INSERT INTO `lecciodivina`.`bead` (`beadID`, `beadNumber`, `beadtype_FK`, `meditation_FK`, `verse_FK`) VALUES ('21', '8', '14', '1', '14');
INSERT INTO `lecciodivina`.`bead` (`beadID`, `beadNumber`, `beadtype_FK`, `meditation_FK`, `verse_FK`) VALUES ('22', '8', '14', '1', '15');
INSERT INTO `lecciodivina`.`bead` (`beadID`, `beadNumber`, `beadtype_FK`, `meditation_FK`, `verse_FK`) VALUES ('23', '9', '14', '1', '16');
INSERT INTO `lecciodivina`.`bead` (`beadID`, `beadNumber`, `beadtype_FK`, `meditation_FK`, `verse_FK`) VALUES ('24', '9', '14', '1', '17');
INSERT INTO `lecciodivina`.`bead` (`beadID`, `beadNumber`, `beadtype_FK`, `meditation_FK`, `verse_FK`) VALUES ('25', '10', '14', '1', '18');
INSERT INTO `lecciodivina`.`bead` (`beadID`, `beadNumber`, `beadtype_FK`, `meditation_FK`, `verse_FK`) VALUES ('26', '10', '14', '1', '19');
INSERT INTO `lecciodivina`.`bead` (`beadID`, `beadNumber`, `beadtype_FK`, `meditation_FK`, `verse_FK`) VALUES ('27', '11', '14', '1', '20');
INSERT INTO `lecciodivina`.`bead` (`beadID`, `beadNumber`, `beadtype_FK`, `meditation_FK`, `verse_FK`) VALUES ('28', '11', '14', '1', '21');
INSERT INTO `lecciodivina`.`bead` (`beadID`, `beadNumber`, `beadtype_FK`, `meditation_FK`, `verse_FK`) VALUES ('29', '11', '14', '1', '22');
INSERT INTO `lecciodivina`.`bead` (`beadID`, `beadNumber`, `beadtype_FK`, `meditation_FK`, `verse_FK`) VALUES ('30', '12', '14', '1', '23');
INSERT INTO `lecciodivina`.`bead` (`beadID`, `beadNumber`, `beadtype_FK`, `meditation_FK`, `verse_FK`) VALUES ('31', '12', '14', '1', '24');
INSERT INTO `lecciodivina`.`bead` (`beadID`, `beadNumber`, `beadtype_FK`, `meditation_FK`, `verse_FK`) VALUES ('32', '13', '14', '1', '25');
INSERT INTO `lecciodivina`.`bead` (`beadID`, `beadNumber`, `beadtype_FK`, `meditation_FK`, `verse_FK`) VALUES ('33', '14', '14', '1', '26');
INSERT INTO `lecciodivina`.`bead` (`beadID`, `beadNumber`, `beadtype_FK`, `meditation_FK`, `verse_FK`) VALUES ('34', '14', '14', '1', '27');
INSERT INTO `lecciodivina`.`bead` (`beadID`, `beadNumber`, `beadtype_FK`, `meditation_FK`, `verse_FK`) VALUES ('35', '15', '14', '1', '28');
INSERT INTO `lecciodivina`.`bead` (`beadID`, `beadNumber`, `beadtype_FK`, `meditation_FK`, `verse_FK`) VALUES ('36', '16', '14', '1', '29');
INSERT INTO `lecciodivina`.`bead` (`beadID`, `beadNumber`, `beadtype_FK`, `meditation_FK`, `verse_FK`) VALUES ('37', '17', '14', '1', '30');
INSERT INTO `lecciodivina`.`bead` (`beadID`, `beadNumber`, `beadtype_FK`, `meditation_FK`, `verse_FK`) VALUES ('38', '17', '14', '1', '31');
INSERT INTO `lecciodivina`.`bead` (`beadID`, `beadNumber`, `beadtype_FK`, `meditation_FK`, `verse_FK`) VALUES ('39', '18', '3', '1', '1');
INSERT INTO `lecciodivina`.`bead` (`beadID`, `beadNumber`, `beadtype_FK`, `meditation_FK`, `verse_FK`) VALUES ('40', '19', '4', '1', '1');



/* --------------------------------------------------------------------------------------- */



/* --------------------------------------------------------------------------------------- */



/* --------------------------------------------------------------------------------------- */



/* --------------------------------------------------------------------------------------- */



/* --------------------------------------------------------------------------------------- */



/* --------------------------------------------------------------------------------------- */
