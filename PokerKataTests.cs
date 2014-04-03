using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PokerKata
{
    [TestClass]
    public class PokerKataTests
    {
        [TestMethod]
        public void HandHasFiveCards()
        {
            // arrange
            var hand = new Hand(new Card[]
            {
                new Card { Face = CardFace.Two, Color = CardColor.Clubs },
                new Card { Face = CardFace.Four, Color = CardColor.Diamonds },
                new Card { Face = CardFace.Six, Color = CardColor.Spades },
                new Card { Face = CardFace.Eight, Color = CardColor.Hearts },
                new Card { Face = CardFace.Ten, Color = CardColor.Clubs }
            });

            // act
            var result = hand.Cards.Length;

            // assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void HighCard()
        {
            // arrange
            var hand = new Hand(new Card[]
            {
                new Card { Face = CardFace.Two, Color = CardColor.Clubs },
                new Card { Face = CardFace.Four, Color = CardColor.Diamonds },
                new Card { Face = CardFace.Six, Color = CardColor.Spades },
                new Card { Face = CardFace.Eight, Color = CardColor.Hearts },
                new Card { Face = CardFace.Ten, Color = CardColor.Clubs }
            });

            // act
            var result = hand.Value;

            // assert
            Assert.AreEqual(HandValue.HighCard, result);
        }

        [TestMethod]
        public void OnePair()
        {
            // arrange
            var hand = new Hand(new Card[]
            {
                new Card { Face = CardFace.King, Color = CardColor.Clubs },
                new Card { Face = CardFace.King, Color = CardColor.Diamonds },
                new Card { Face = CardFace.Six, Color = CardColor.Spades },
                new Card { Face = CardFace.Eight, Color = CardColor.Hearts },
                new Card { Face = CardFace.Ten, Color = CardColor.Clubs }
            });

            // act
            var result = hand.Value;

            // assert
            Assert.AreEqual(HandValue.Pair, result);
        }

        [TestMethod]
        public void TwoPairs()
        {
            // arrange
            var hand = new Hand(new Card[]
            {
                new Card { Face = CardFace.King, Color = CardColor.Clubs },
                new Card { Face = CardFace.King, Color = CardColor.Diamonds },
                new Card { Face = CardFace.Queen, Color = CardColor.Spades },
                new Card { Face = CardFace.Queen, Color = CardColor.Hearts },
                new Card { Face = CardFace.Ten, Color = CardColor.Clubs }
            });

            // act
            var result = hand.Value;

            // assert
            Assert.AreEqual(HandValue.TwoPairs, result);
        }

        [TestMethod]
        public void ThreeOfKind()
        {
            // arrange
            var hand = new Hand(new Card[]
            {
                new Card { Face = CardFace.King, Color = CardColor.Clubs },
                new Card { Face = CardFace.King, Color = CardColor.Diamonds },
                new Card { Face = CardFace.King, Color = CardColor.Spades },
                new Card { Face = CardFace.Queen, Color = CardColor.Hearts },
                new Card { Face = CardFace.Ten, Color = CardColor.Clubs }
            });

            // act
            var result = hand.Value;

            // assert
            Assert.AreEqual(HandValue.ThreeOfKind, result);
        }

        [TestMethod]
        public void FourOfKind()
        {
            // arrange
            var hand = new Hand(new Card[]
            {
                new Card { Face = CardFace.King, Color = CardColor.Clubs },
                new Card { Face = CardFace.King, Color = CardColor.Diamonds },
                new Card { Face = CardFace.King, Color = CardColor.Spades },
                new Card { Face = CardFace.King, Color = CardColor.Hearts },
                new Card { Face = CardFace.Ten, Color = CardColor.Clubs }
            });

            // act
            var result = hand.Value;

            // assert
            Assert.AreEqual(HandValue.FourOfKind, result);
        }

        [TestMethod]
        public void FullHouse()
        {
            // arrange
            var hand = new Hand(new Card[]
            {
                new Card { Face = CardFace.King, Color = CardColor.Clubs },
                new Card { Face = CardFace.King, Color = CardColor.Diamonds },
                new Card { Face = CardFace.King, Color = CardColor.Spades },
                new Card { Face = CardFace.Queen, Color = CardColor.Hearts },
                new Card { Face = CardFace.Queen, Color = CardColor.Clubs }
            });

            // act
            var result = hand.Value;

            // assert
            Assert.AreEqual(HandValue.FullHouse, result);
        }

        [TestMethod]
        public void Straight()
        {
            // arrange
            var hand = new Hand(new Card[]
            {
                new Card { Face = CardFace.Five, Color = CardColor.Clubs },
                new Card { Face = CardFace.Six, Color = CardColor.Diamonds },
                new Card { Face = CardFace.Seven, Color = CardColor.Spades },
                new Card { Face = CardFace.Eight, Color = CardColor.Hearts },
                new Card { Face = CardFace.Nine, Color = CardColor.Clubs }
            });

            // act
            var result = hand.Value;

            // assert
            Assert.AreEqual(HandValue.Straight, result);
        }

        [TestMethod]
        public void Flush()
        {
            // arrange
            var hand = new Hand(new Card[]
            {
                new Card { Face = CardFace.Three, Color = CardColor.Diamonds },
                new Card { Face = CardFace.Five, Color = CardColor.Diamonds },
                new Card { Face = CardFace.Seven, Color = CardColor.Diamonds },
                new Card { Face = CardFace.Nine, Color = CardColor.Diamonds },
                new Card { Face = CardFace.Ten, Color = CardColor.Diamonds }
            });

            // act
            var result = hand.Value;

            // assert
            Assert.AreEqual(HandValue.Flush, result);
        }

        [TestMethod]
        public void StraightFlush()
        {
            // arrange
            var hand = new Hand(new Card[]
            {
                new Card { Face = CardFace.Five, Color = CardColor.Diamonds },
                new Card { Face = CardFace.Six, Color = CardColor.Diamonds },
                new Card { Face = CardFace.Seven, Color = CardColor.Diamonds },
                new Card { Face = CardFace.Eight, Color = CardColor.Diamonds },
                new Card { Face = CardFace.Nine, Color = CardColor.Diamonds }
            });

            // act
            var result = hand.Value;

            // assert
            Assert.AreEqual(HandValue.StraightFlush, result);
        }
    }
}