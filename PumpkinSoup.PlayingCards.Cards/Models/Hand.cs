using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PumpkinSoup.PlayingCards.Interfaces;

namespace PumpkinSoup.PlayingCards.Cards.Models
{
	public class Hand : IHand
	{
		private int _count;
		private bool _isReadOnly;
		private int? _maxSize;

		public IEnumerator<ICard> GetEnumerator()
		{
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(ICard item)
		{
			throw new NotImplementedException();
		}

		public void Clear()
		{
			throw new NotImplementedException();
		}

		public bool Contains(ICard item)
		{
			throw new NotImplementedException();
		}

		public void CopyTo(ICard[] array, int arrayIndex)
		{
			throw new NotImplementedException();
		}

		public bool Remove(ICard item)
		{
			throw new NotImplementedException();
		}

		public int Count
		{
			get { return _count; }
		}

		public bool IsReadOnly
		{
			get { return _isReadOnly; }
		}

		public int? MaxSize
		{
			get { return _maxSize; }
		}

		public void Add(params ICard[] cards)
		{
			throw new NotImplementedException();
		}

		public void Remove(params ICard[] cards)
		{
			throw new NotImplementedException();
		}
	}
}
