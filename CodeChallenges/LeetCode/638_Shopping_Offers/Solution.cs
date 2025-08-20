namespace CodeChallenges.LeetCode._638_Shopping_Offers;

public class Solution {
    public int ShoppingOffers(IList<int> price, IList<IList<int>> special, IList<int> needs) => DFS(price, 0, special, needs.ToArray(), 0, int.MaxValue);
    private int DFS(IList<int> price, int i, IList<IList<int>> special, int[] needs, int curr, int min)
    {
        if (curr >= min) return min;
        if (i == special.Count)
        {
            for (var j = 0; j < price.Count; ++j) curr += price[j] * needs[j];
            return Math.Min(min, curr);
        }
        var notTake = curr;
        for (var j = 0; j < needs.Length; ++j)
        {
            notTake += needs[j] * price[j];
            if (notTake >= min) break;
        }
        min = Math.Min(min, notTake);
        var offer = special[i];
        var canTake = true;
        for (var j = 0; j < needs.Length; ++j)
        {
            if (offer[j] > needs[j])
            {
                canTake = false;
                break;
            }
        }

        if (canTake)
        {
            for (var j = 0; j < needs.Length; ++j)
            {
                needs[j] -= offer[j];
            }
            min = Math.Min(min, DFS(price, i, special, needs, curr + offer[offer.Count - 1], min));
            for (var j = 0; j < needs.Length; ++j)
            {
                needs[j] += offer[j];
            }
        }

        return Math.Min(min, DFS(price, i + 1, special, needs, curr, min));
    }
}