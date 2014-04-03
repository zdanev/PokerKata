﻿using System;
using System.Linq;

namespace PokerKata
{
    public class Hand
    {
        public Card[] Cards { get; private set; }

        public Hand(Card[] cards)
        {
            if (cards == null || cards.Length != 5)
                throw new ArgumentException("cards");

            Cards = cards;
        }

        public HandValue Value
        {
            get
            {
                // iteration 1: var faces = Cards.Select(c => c.Face).Distinct().Count();

                var colors = Cards.Select(c => c.Color).Distinct().Count();

                var faces = Cards
                    .GroupBy(c => c.Face)
                    .Select(g => new {Face = g.Key, Count = g.Count()})
                    .OrderByDescending(x => x.Count);

                if (IsStraight() && colors == 1)
                    return HandValue.StraightFlush;

                if (IsStraight())
                    return HandValue.Straight;

                if (colors == 1)
                    return HandValue.Flush;

                switch (faces.Count())
                {
                    case 2:
                        return faces.First().Count == 4 ? HandValue.FourOfKind : HandValue.FullHouse;

                    case 3:
                        return faces.First().Count == 3 ? HandValue.ThreeOfKind : HandValue.TwoPairs;

                    case 4:
                        return HandValue.Pair;

                    default: // case 5:
                        return HandValue.HighCard;
                }
            }
        }

        private bool IsStraight()
        {
            var orderedCards = Cards.OrderBy(c => c.Face).ToArray();
            for (int i = 1; i < 5; i++)
                if ((int) (orderedCards[i].Face) != 1 + (int) (orderedCards[i - 1].Face)) return false;

            return true;
        }
    }
}