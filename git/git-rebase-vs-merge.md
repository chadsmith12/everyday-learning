# Git Rebase vs. Merge

When you merge with Git you can see "history." You are not really "rewriting history." The branches that everyone has worked on still exist. When you do a Rebase it is like you are erasing or changing history. If there are a lot of different branches, then it can make the Git graph look cleaner.

## What Happens with a Rebase
When you do a Rebase you end up rewritting history. If you have a new branch that you did three changes to, and also on the main branch you have done a couple of changes since after that new branch was made. When you do a rebase, you pick up  the changes you did on your new branch and now base it off of the changes on your main branch.

## Doing a Rebase
On your new branch that you want to rebase you can do: `git rebase <main_branch_name>` where `<main_branch_name>` is  the branch that you want to rebase it on. If you end up running this command with a `-i` argument, then you will end up going into interactive mode. When you are in interactive mode, you can end up picking and the choosing the exact moments in time that you want to keep. 