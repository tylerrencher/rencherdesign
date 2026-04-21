---
title: "Sizing a solar array: why the number your contractor gives you is probably wrong."  
slug: solar-sizing
date: 2026-03-01
category: Off-Grid Living
lede: Most solar quotes are sized for average daily production in good conditions. They're not sized for January, which is the month that determines whether your system works. Here's how to think about the number that actually matters. 
read-minutes: 11
---

I have 26 kW of solar installed on my property — 20 kW on the roof and 6 kW on a ground mount. My home has nine full-time occupants. We run two dishwashers, two ranges, a washer and dryer, a heat pump HVAC system, a hybrid water heater, three chest freezers, two refrigerators, and the full complement of electronics and lighting that a large family generates. We have been off-grid since 2023. I went into this knowing more than most homeowners do about how solar systems actually perform — because I did the analysis myself before a single panel was ordered. Most people don't do that analysis, and the quotes they receive from solar contractors reflect it.

This entry is for anyone who is planning an off-grid or heavily solar-dependent home and wants to understand how the sizing actually works — so they can evaluate what they're being told rather than accepting a number on faith.

## The number most quotes are based on

When a solar contractor quotes you a system, they typically start with your annual energy consumption — usually pulled from twelve months of utility bills — and then size an array to produce that much energy over the course of a year. The calculation is straightforward: if your household uses 12,000 kWh per year and your location receives an average of 5 peak sun hours per day, they calculate how many panels at a given wattage will produce 12,000 kWh annually and quote you that system.

This approach has a fundamental problem for off-grid: it optimizes for the annual average, not for the worst month. And in an off-grid home the worst month is the only month that actually matters for system adequacy. If your system produces 200% of what you need in July and 40% of what you need in December, you do not have a system that works. You have a system that produces a lot of surplus energy in summer that you cannot store or use, and a lot of hours on your generator in the winter. Assuming you have enough battery capacity to get through the night and enough generator production capacity to charge the batteries and run the house.

The annual-average approach makes sense when solar is primarily being used to reduce a grid-connected electricity bill and in net-zero applications. In that context, annual production is a reasonable proxy for annual savings — surplus production in summer earns credits, deficit in winter is covered by the grid. But for an off-grid home, the grid isn't there to cover the deficit. The battery has to cover it, and the battery has to be charged by the solar array. If the array can't charge the battery fast enough during December's short cloudy days, you run the generator. How often you run it depends entirely on whether your system was sized for December, not for the annual average.

## What actually determines winter production

Solar production in winter is lower than summer for three separate reasons, and understanding all three matters for sizing the system correctly.

### Shorter days

Peak sun hours — the standard metric for solar resource — are lower in winter simply because the days are shorter. At 39 degrees north latitude (roughly central Utah), December has about 3.8 peak sun hours on a clear day. July has about 7.2. That alone means winter daily production is roughly half of summer daily production from the same array, before accounting for anything else.

### Lower sun angle

In winter, the sun rises lower in the sky and never gets as high overhead as it does in summer. A fixed roof-mounted array is typically tilted at an angle that produces well in spring and fall but is further from optimal in both midsummer and midwinter — tilted too shallow for the low winter sun and too steep for the high summer sun. At a 4:12 roof pitch (about 18 degrees), which is what I have, the panels are significantly less efficient in December than they would be on a steeper roof or on an adjustable ground mount. My steeply tilted ground-mounted array (55 degrees) produces 45% of my winter power despite being only 30% of the rooftop array capacity. Panel orientation can give you a 50% production increase during the time you need it most with careful design!

### Weather and cloud cover

Winter in most parts of the country is cloudier than summer. Cloud cover reduces production more than most people expect — a fully overcast day might produce 5–25% of clear-sky production, depending on cloud thickness. Partly cloudy days are less predictable. For sizing purposes, you need to use actual historical data for your specific location rather than theoretical clear-sky production, because the difference between "five peak sun hours on a clear day" and "what December actually looks like" can be substantial.

## What actually determines winter demand

The production side is half the picture. The demand side — how much energy your household actually needs in winter — is equally important, and it's where most off-grid system designs fall apart.

### Heating load is the dominant variable

In most off-grid homes all electric homes, the single largest electrical load in winter is space heating. If you're heating with a heat pump — which is the only system I recommend for high-efficiency off-grid homes — the heating system draws significantly more power in January and February than in any other months. And that load is directly correlated with the coldest, darkest weather: the days when your solar production is lowest are almost always the days when your heating load is highest. This correlation is the central challenge of off-grid system design.

The saving grace is that heat pumps are more efficient than resistance heaters — for every unit of electrical energy they consume, they deliver two to four units of heat, depending on the outdoor temperature. At very cold temperatures (below about 20°F), heat pump efficiency drops and heating load rises simultaneously. This is the worst-case scenario and needs to be specifically accounted for in the system design.

In my home, the well pump actually draws about as much energy over the course of a winter as HVAC — 2.45 MWh for the well vs. 2.24 MWh and 2.70 MWh for heat in the last 2 years. That was a surprise and illustrates why generic assumptions about load composition can mislead a system design. Every home's load profile is different, and the only way to size the system correctly is to know your specific loads.

I'll give you another example. Lighting. LED lights are very energy efficient, but when you have a well lit home like I do they use a lot of power. Everyone told me that I was wrong when I was analyzing my predicted energy consumption and said that lighting would be one of our largest loads. I was right. The #3 biggest energy consumer in my home each winter is lighting. Hot water is #4 if you can believe it.

### The load profile, not just the total

Total annual consumption is a useful number for bill calculations. It's nearly useless for off-grid system design. What matters is the load profile: how much energy the household draws hour by hour, day by day, and month by month. A household that uses 2,000 kWh in a month with 70% of consumption during the day has a very different battery and array requirement than the same household with 70% consumption at night, when the load is drawing down the battery.

For a properly sized system, you want to know: what is the household's demand in the worst winter month, and how is that demand shaped during the day and week? The answer determines the array size, the battery size, the generator sizing, and the acceptable generator run percentage.

## The battery question is separate from the array question

Battery and array are related but distinct. The array determines how much energy you can capture. The battery determines how much energy you can store. Both need to be sized, and they interact with each other in ways that a simple annual-production calculation doesn't capture.

### Autonomy days is the wrong metric

You'll often hear battery banks described in terms of "days of autonomy" — how many days the battery can power the home without any solar input. This metric sounds useful but is completely useless. A home varies in power usage every day. In March 2026, I had some days at 54 kWh and some days at 95 kWh. I averaged about 70 kWh for the month and my highest 3 day usage was 85 kWh per day. According to days of autonomy do I need a battery bank sized at 210 to 255 kWh. Roughly double what I have installed. Money would be far better spent oversizing the solar array than on batteries to meet the autonomy day spec.

In my analysis of my own system, I found that the critical scenario isn't a single catastrophically bad day. It's a string of mediocre days — six or eight days of partial cloud cover where the array is producing 30–80% of household usage each day and the battery is slowly depleting. Your array produces power every day and that should be considered. The worst day I've ever seen for my array is 6 kWh of production. The worst 2 day production was 16 kWh. Dark days, but the generator carries us through that without spending another $60k on batteries. Autonomy days assumes the system is not doing it's job. We aren't building nuclear bunkers. We're going to assume that systems are operating as intended and provide adequate fall backs if true emergencies occur.

### Battery sizing for the actual scenario

Rather than sizing for theoretical autonomy days, I'd encourage you to think about this question: given your array size and your location's actual winter weather patterns, how long is a typical period of below-average production, and how much of a deficit does that create relative to your daily load? I sized my battery bank to carry us through 1 day of our theoretical maximum demand and 1.5-2 days of normal demand with limited generation from the array. The generator covers the remainder. Some amount of generator runtime is a designed part of the system — not a failure mode.

This is a meaningful reframe. An off-grid system designed to eliminate generator use entirely is much larger and more expensive than one designed to minimize generator use to an acceptable level. For most households, the economically optimal system involves some generator runtime during bad winter stretches — typically measured in tens of hours per year rather than hundreds. My analysis before building suggested I should plan for up to 200 generator-hours in a bad winter. The actual worst winter I've experienced required less than that.

## What a correct sizing analysis actually looks like

A properly done off-grid system design starts from the load, not from the array. You build up from the individual loads in the home — appliance by appliance, accounting for wattage, daily hours of use, and seasonal variation — to arrive at a daily energy budget for each month of the year. You then model the available solar production for each month using actual historical weather data for your specific location. The gap between production and demand in the worst months tells you how much battery capacity and generator runtime you need, and that in turn tells you what array size produces the best balance across cost, battery size, and generator use.

This is not a quick calculation. It's the kind of analysis that takes hours to do correctly, requires software or significant spreadsheet work, and produces a system design that actually reflects your home, your location, and your family's habits. The fact that most solar contractors don't do it isn't because they don't know it's necessary — it's because most of their customers are grid-connected and don't need it. Their tools and habits are calibrated for that market, not for off-grid design.

I ended up settling on a battery bank sized to 1 day of my maximum theoretical usage in winter and about 1.5-2 days of predicted average usage with minimal solar input. I sized my solar array to produce about 1.25 times what I estimated we would need in winter. My initial battery sizing was based on how I knew my family works. I needed to have complete confidence that I could be away for an entire day in terrible weather and my wife wouldn't have to do anything. I ran a bunch of simulations using publicly available solar irradiance data and actual production data I was able to pull from local homeowners that made the data public with their system configuration details. I used that data to dial in the battery, array, and generator sizing to work well in 3, 5, 7, and 14 day blocks of time. The system performs as designed and extremely well.

## What I produce for off-grid clients

The Off-Grid System Design I offer produces a load profile analysis — every significant load in the home, estimated by season, with peak demand accounted for separately from average demand. I produce a production model for using historical weather data and local production data. I produce a system specification: array size, battery capacity, and generator sizing — with an estimate of what generator runtime looks like in a good winter versus a bad one with recommended fuel storage capacity.

That analysis is what I did for my own home before I engaged a solar contractor. My system has performed within the range I predicted. I can do that analysis for you too so you can evaluate your solar contractor estimates. The estimates for my home had the right amount of inverter capacity, 1/3 the battery capacity, half the solar array generation, and half the generator capacity that I predicted we would need. Those systems were sized for summer and they would have been approved by the state system design assessor and the county inspectors. I look out for your interests. If a properly sized system is outside of your budget, I'll tell you, and help you navigate a path forward either off or on grid. That is some of the best money you could spend. The risk is being in a home that doesn't work, can't work, and can't be sold.