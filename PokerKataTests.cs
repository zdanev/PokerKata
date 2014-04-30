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
            var hand = new Hand(new[]
            {
                new Card { Rank = Rank.Two, Suit = Suit.Clubs },
                new Card { Rank = Rank.Four, Suit = Suit.Diamonds },
                new Card { Rank = Rank.Six, Suit = Suit.Spades },
                new Card { Rank = Rank.Eight, Suit = Suit.Hearts },
                new Card { Rank = Rank.Ten, Suit = Suit.Clubs }
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
            var hand = new Hand(new[]
            {
                new Card { Rank = Rank.Two, Suit = Suit.Clubs },
                new Card { Rank = Rank.Four, Suit = Suit.Diamonds },
                new Card { Rank = Rank.Six, Suit = Suit.Spades },
                new Card { Rank = Rank.Eight, Suit = Suit.Hearts },
                new Card { Rank = Rank.Ten, Suit = Suit.Clubs }
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
            var hand = new Hand(new[]
            {
                new Card { Rank = Rank.King, Suit = Suit.Clubs },
                new Card { Rank = Rank.King, Suit = Suit.Diamonds },
                new Card { Rank = Rank.Six, Suit = Suit.Spades },
                new Card { Rank = Rank.Eight, Suit = Suit.Hearts },
                new Card { Rank = Rank.Ten, Suit = Suit.Clubs }
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
            var hand = new Hand(new[]
            {
                new Card { Rank = Rank.King, Suit = Suit.Clubs },
                new Card { Rank = Rank.King, Suit = Suit.Diamonds },
                new Card { Rank = Rank.Queen, Suit = Suit.Spades },
                new Card { Rank = Rank.Queen, Suit = Suit.Hearts },
                new Card { Rank = Rank.Ten, Suit = Suit.Clubs }
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
            var hand = new Hand(new[]
            {
                new Card { Rank = Rank.King, Suit = Suit.Clubs },
                new Card { Rank = Rank.King, Suit = Suit.Diamonds },
                new Card { Rank = Rank.King, Suit = Suit.Spades },
                new Card { Rank = Rank.Queen, Suit = Suit.Hearts },
                new Card { Rank = Rank.Ten, Suit = Suit.Clubs }
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
            var hand = new Hand(new[]
            {
                new Card { Rank = Rank.King, Suit = Suit.Clubs },
                new Card { Rank = Rank.King, Suit = Suit.Diamonds },
                new Card { Rank = Rank.King, Suit = Suit.Spades },
                new Card { Rank = Rank.King, Suit = Suit.Hearts },
                new Card { Rank = Rank.Ten, Suit = Suit.Clubs }
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
            var hand = new Hand(new[]
            {
                new Card { Rank = Rank.King, Suit = Suit.Clubs },
                new Card { Rank = Rank.King, Suit = Suit.Diamonds },
                new Card { Rank = Rank.King, Suit = Suit.Spades },
                new Card { Rank = Rank.Queen, Suit = Suit.Hearts },
                new Card { Rank = Rank.Queen, Suit = Suit.Clubs }
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
            var hand = new Hand(new[]
            {
                new Card { Rank = Rank.Five, Suit = Suit.Clubs },
                new Card { Rank = Rank.Six, Suit = Suit.Diamonds },
                new Card { Rank = Rank.Seven, Suit = Suit.Spades },
                new Card { Rank = Rank.Eight, Suit = Suit.Hearts },
                new Card { Rank = Rank.Nine, Suit = Suit.Clubs }
            });

            // act
            var result = hand.Value;

            // assert
            Assert.AreEqual(HandValue.Straight, result);
        }

        [TestMethod]
        public void Straight2()
        {
            // arrange
            var hand = new Hand(new[]
            {
                new Card { Rank = Rank.Ace, Suit = Suit.Clubs },
                new Card { Rank = Rank.Two, Suit = Suit.Diamonds },
                new Card { Rank = Rank.Three, Suit = Suit.Spades },
                new Card { Rank = Rank.Four, Suit = Suit.Hearts },
                new Card { Rank = Rank.Five, Suit = Suit.Clubs }
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
                new Card { Rank = Rank.Three, Suit = Suit.Diamonds },
                new Card { Rank = Rank.Five, Suit = Suit.Diamonds },
                new Card { Rank = Rank.Seven, Suit = Suit.Diamonds },
                new Card { Rank = Rank.Nine, Suit = Suit.Diamonds },
                new Card { Rank = Rank.Ten, Suit = Suit.Diamonds }
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
                new Card { Rank = Rank.Five, Suit = Suit.Diamonds },
                new Card { Rank = Rank.Six, Suit = Suit.Diamonds },
                new Card { Rank = Rank.Seven, Suit = Suit.Diamonds },
                new Card { Rank = Rank.Eight, Suit = Suit.Diamonds },
                new Card { Rank = Rank.Nine, Suit = Suit.Diamonds }
            });

            // act
            var result = hand.Value;

            // assert
            Assert.AreEqual(HandValue.StraightFlush, result);
        }
    }
}