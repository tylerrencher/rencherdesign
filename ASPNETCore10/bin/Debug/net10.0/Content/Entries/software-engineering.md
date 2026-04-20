---
title: How software engineering made me a better home designer.  
slug: software-engineering
date: 2026-03-01
category: Design
lede: Thirteen years building systems for a living taught me how to think about complexity, manage stakeholder expectations, and make decisions that age well. Those skills transfer more directly to residential design than I expected — and in some ways they're more valuable here, because you only get one shot. 
readminutes: 12
---

When people find out that I'm a professional software engineer also designs homes, the reaction is usually: "How can you do two completely different things?" They assume that the two fields are unrelated, that I left one world behind and learned an entirely different one. That isn't quite right. The longer I design homes, the more I recognize how directly the thinking I built in software applies. Not the technical details. The underlying habits.

This entry is about what I bring from software to homes and why I think that makes me a different kind of designer than someone who came up through architecture school or learned design on the job site. Some of it is about tools and process. Most of it is about how to think.

## There are some rules that are hard and fast

In software, code is written according to a language specification. A tool called a complier translates code to something the machine can execute. The software author can make logic mistakes in how the code processes data or performs a computation, but the author can't make a typo or the compiler will fail to translate the code for the machine. In home design we have building codes — hard and fast rules that must be adhered to that are checked by a building department and inspector as the build progresses. That doesn't prevent bad design decisions though. Like forcing people to walk through the kitchen to get to the mudroom. I've made a lot of mistakes in software where things just didn't fit together right for how data moved through a system or how a user interacts with the program. Learning from those mistakes helps me spot the same kinds of bad patterns in homes before they are even built.

## The cost of change an important concept in both fields

In software, there's a well-understood principle about defects: they are cheapest to find in the requirements phase, more expensive in design, significantly more expensive in development, and extremely expensive in production where mistakes cost money and your reputation. Every step toward deployment makes a fundamental problem harder and costlier to fix. This is why the best engineering teams invest heavily in getting requirements right before writing a line of code, and why the discipline of upfront design — figuring out how the system should work before building it — has such a strong return.

I spent years working in environments where this principle was understood and taken seriously. Requirements reviews. Architecture reviews. Code reviews. Each is an attempt to catch problems at the cheapest possible point in the development cycle, before the cost of change becomes prohibitive. After thirteen years of that, it becomes a reflex: find the problem early, when fixing it is cheap.

Home construction follows the same pattern with the same mathematical ruthlessness — and too often doesn't treated that way. A change to the floor plan during discovery costs nothing: a conversation, a revised sketch, a different idea. The same change once the plans are complete might cost $100-200 dollars to update the plans. The same change during framing could cost thousands: labor to tear out what's been built, materials wasted, schedule disrupted, coordination across trades undone. The same change after drywall is up can cost more than it's worth to make at all, and the client lives with it forever. The pattern is identical. The consequences are just physical instead of digital.

> "In software, you can release a new version. You can patch a bug in production. In a house, once the concrete is poured, it's poured."

What I do differently as a result of this background is front-load. I ask more questions before I start drawing than most draftsmen ask total. I push clients to make decisions — real decisions, with real implications — while those decisions are still free to make. The discovery process I run is longer and more demanding than clients sometimes expect. But it's the equivalent of a thorough requirements phase: the work that makes everything downstream go more smoothly and produce a better result.

## Systems thinking: everything connects to everything else

A software system is a collection of components that interact. Change one component and you change the behavior of everything it touches and that touches it. Build a feature without understanding the downstream dependencies and you break something you didn't expect to break. The discipline of systems thinking — holding the whole architecture in mind while working on a part of it, understanding how changes propagate — is the core skill of a good engineer.

A home is also a system. The building envelope affects the HVAC load. The HVAC load affects the equipment sizing. The equipment sizing affects the duct design. The duct design affects where the registers go. The register locations affect the room layout. The room layout affects the window placement. The window placement affects the solar gain, which feeds back into the HVAC load. None of these are independent decisions. Pull on any one of them and the others can move.

Most residential design treats these as sequential decisions: design the floor plan, then place the windows, then figure out the mechanical on site. The problem with that sequence is that by the time you're sizing the HVAC, the decisions that most affect the load — envelope performance, window specifications, air tightness targets — were not considered.

I design differently. The envelope performance targets, the HVAC strategy, and the room layout are developed together — because they're not independent decisions and shouldn't be treated as such. For off-grid homes especially, the electrical load affects the solar system size, which affects the roof area needed, which affects the building footprint, which affects the floor plan. These decisions have to be made as a system, not in sequence.

## Managing stakeholders who have conflicting requirements

Most software projects involve multiple stakeholders with different, often conflicting, ideas about what the system should do. A product manager wants features. An engineer wants stability. A security team wants control. A designer wants simplicity. An executive wants it done by Friday. Getting alignment among people with genuinely different objectives — without letting any one voice dominate in ways that damage the outcome — is a significant part of the job.

Custom home design has the same dynamic, except the stakeholders are usually two people who are married to each other. That doesn't make the conflict less real. Spouses routinely have genuinely different priorities about what their home should be: one wants an open kitchen connected to the living room, one wants a kitchen with walls where cooking smells stay contained. One wants a master bedroom far from the children, one wants to be nearby. One wants to spend the money on the kitchen, one wants to spend it on a shop. One wants a second story, one wants everything on one floor.

A designer who just draws what one spouse asks for is going to produce a home that the other spouse didn't agree to. A designer who tries to make both spouses happy without surfacing the conflict is going to produce a home that satisfies neither. The job is to get the conflict on the table explicitly, understand what's actually driving each position, and find a design resolution that both parties understand and genuinely accept — rather than one that papers over the disagreement until they're living in it.

::: callout
**The most useful question in a discovery conversation:** "What does your spouse think about this?" Not because I need permission, but because the answer tells me immediately whether we're talking about a genuine shared priority or a preference one person holds that the other hasn't been asked about yet. Surfacing that gap early is one of the most valuable things a designer can do.
:::

The skill that makes this possible is one I developed doing stakeholder management in software: the ability to make someone feel genuinely heard even while pushing back on their position. To understand the need behind the stated preference — what they're actually trying to achieve — and then explore whether the stated solution is the only way to get there. In software, a product manager who wants a feature often wants an outcome. Sometimes the outcome can be achieved more cleanly with a different feature. The same is true of clients who want a specific room or a specific layout: what they usually want is a specific thing the room or layout would give them, and that need can often be met in more than one way.

## Documentation that survives handoffs

In software, a system that isn't documented is a liability. The engineer who built it knows how it works. Everyone else is guessing. When that engineer leaves, the knowledge leaves with them, and the next person to touch the system is working from incomplete information. Good engineering teams treat documentation as a first-class deliverable, not an afterthought — because the system will eventually be maintained by someone who wasn't in the room when the decisions were made.

Residential construction has a documentation problem. Most homes are built from drawing sets that specify what the building should look like but not why certain decisions were made. The designer knows why the window is in that location, why the wall assembly is detailed that particular way, why the HVAC register is where it is. The general contractor may know some of it. The subcontractors know very little. When a question arises in the field — and questions always arise in the field — the people making the decision often don't have access to the reasoning that should inform it.

My drawing sets include more annotation than is strictly required for permit submission. Not because building officials ask for it, but because my drawings are also instructions to the people who will build from them. A note on a wall section that says "continuous air barrier — see detail A-401, do not substitute" is different from a wall section that just shows the layers without comment. The first gives a framer the information they need to make the right call when the detail I specified isn't available at the supply house and they're deciding whether to call me or substitute. The second leaves them guessing.

## Getting to yes through other people's processes

Software engineers spend a significant portion of their careers navigating bureaucratic processes they didn't design and can't change. Code reviews. Change control boards. Security reviews. Compliance audits. The work itself is only part of the job. Getting the work approved, released, and adopted — through people and processes that have their own priorities, their own timelines, and their own risk tolerances — is a separate skill that takes years to develop.

Building permit processes are the same kind of challenge. Building officials have specific things they're looking for, specific ways they expect to see information presented, and specific processes for handling things that are outside their normal experience. They're not obstacles — they're people doing a job with the tools and training they have. But navigating their process effectively, without unnecessary friction, while still building the home you actually want, requires the same combination of preparation, patience, and diplomatic persistence that I learned doing software.

When I submitted plans to a county that was not familiar with reviewing off-grid electrical systems, I didn't go in arguing that they had to approve it. I went in with technical documentation from the equipment manufacturers, code references from the IRC, a clear explanation of how the system worked and why it was safe, and a design from a recognized solar design company. I understood that the building officials weren't opposed to the system — they just didn't know how to evaluate it. My job was to give them the information they needed to approve it confidently, in a format they could work with. That's a stakeholder management problem, not a technical problem. The technical part was easy. The process part is what took months.

## Designing for maintenance, not just for launch

One of the most useful distinctions in software is between code that's easy to write and code that's easy to maintain. Junior engineers write for the computer — to make the program do what it's supposed to do. Senior engineers write for the next person — to make the code readable, modifiable, and debuggable by someone who wasn't there when it was written. The difference between the two orientations shows up most clearly years later, when the original engineer is gone and someone else is trying to understand what was built and why.

Homes need maintenance too — and some homes are much easier to maintain than others. Access panels that let someone reach a shutoff valve or inspect a critical connection without cutting into drywall. Mechanical rooms with enough space to actually work in. Labeled circuits in an electrical panel that's sized with room to grow. Conduit instead of direct-buried wire runs, so the wire can be replaced someday without an excavator. Pipe chases that can be accessed from a utility space rather than requiring a finished ceiling to be opened.

None of these things affect how the house looks or how it feels to live in on day one. All of them affect how the house behaves at year fifteen, when something needs to be serviced or replaced. I think about them because I spent years maintaining the systems I built — and I know how often the original choices either helped or hindered that work. A home designer who has never been on the wrong end of an inaccessible shutoff valve probably doesn't think about it. I do.

## The one place where software thinking has limits

In software, you learn to accept that the first version of anything is wrong, and that iteration is how you find the right version. The more experience you get the better your first version are, but the process is still: ship early, learn from real usage, revise. The feedback loop is how the product improves. You build a tolerance for imperfection because imperfection is the starting point, not a failure.

That mindset is useful in design and actively harmful in construction. A home is not a product you can iterate. You cannot ship version one, get feedback from the family living in it, and then patch the floor plan in the next release. The decisions made in the design phase are the decisions the family lives with. The tolerance for imperfection that serves an engineer well in software has to be replaced, in home design, by a commitment to getting it right before anything is built — because there is no version two.

I think about this permanence all the time. Initial designs can be shipped fast, but the final design needs some time to sit and bake in a client's mind and my own. They are making a permanent investment in a permanent building. What serves clients well is the opposite: thoroughness in the design phase, precision in the drawings, and the willingness to hold a decision open until it can be made well rather than closing it quickly so the project can move forward.

The best of what I learned in software transferred directly. The worst of it had to be left behind. Knowing the difference is what thirteen years of building things has taught me.