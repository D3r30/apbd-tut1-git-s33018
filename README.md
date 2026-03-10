#APBD
Merge wasn't fast-forward because this time we implemented some new changes to the main branch, so the main hasn't stayed the same as the base commit from which we went working on the other branch

### Questions:
1.Git performs fast-forward merge when there is no new changes in the branch you are trying to merge to, which were made during your work in other branch, so the branch you are trying to merge to stays the same as the base of the branch your working on, while if some changes were made to the branch you want to merge to, while you were working in other branch, you need merge commit.

2.The difference is that when you merge you combine code from two branches, while when you are rebasing you simply change the commit that your branch was based on to some other commit without changing the code.

3.I opened the conflicted file in Rider and manually chose which version of the changed line to keep, then completed the merge.